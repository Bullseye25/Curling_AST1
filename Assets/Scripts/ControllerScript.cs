using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerScript : MonoBehaviour 
{
    public static ControllerScript instance = null;

    public GameObject m_fakeStone;

    internal Material m_arrowMaterial;

    internal LineRenderer m_arrow;

    public Transform m_arrowStartingPoint;

    private Vector3[] m_points = new Vector3[2];

    private Vector3 m_targetDir, m_dir, m_defaultStonePosition;

    internal MeshCollider m_collider;

    internal GameObject m_brooms;

	internal Rigidbody m_rigidbody;

    public float m_maxForce, m_minForce, m_arrowRotationSpeed, m_curlingDiraction, m_curlingForce = 0.35f;

    internal bool m_stoneClone = true, m_doCurling = false;

    public Slider m_curlingSlider;

    public Color m_belowAverageSpeed, m_averageSpeed, m_aboveAverageSpeed;

    internal int m_turn = 0;

	// Use this for initialization
	private void Awake()
	{
		if (instance == null)
			instance = this;
        
        m_defaultStonePosition = transform.position;

        m_brooms = GameObject.FindWithTag("Broom");

        m_brooms.SetActive(false);

        m_arrow = GetComponent<LineRenderer>();

        m_arrowMaterial = m_arrow.materials[0];

        m_arrow.useWorldSpace = true;

        m_rigidbody = GetComponent<Rigidbody>();

        m_collider = GetComponent<MeshCollider>();

		m_collider.material.staticFriction = 0;

        if (!m_curlingSlider.gameObject.activeInHierarchy)
            m_curlingSlider.gameObject.SetActive(true);

        ResetCurlingForce();

        m_curlingSlider.value = 0;

        m_arrowMaterial.SetColor("_EmissionColor", Color.black);
	}

    //this function will be called every time the next turn is called
    private void OnEnable()
    {
        //if the curling slider is not active in project
		if (!m_curlingSlider.gameObject.activeInHierarchy)
            //activate the slider
			m_curlingSlider.gameObject.SetActive(true);

        //by default the friction will be 0 which will make the surface of the stone smooth as it can be
        m_collider.material.staticFriction = 0;

        //reset the rotation
        transform.eulerAngles = Vector3.zero;

        ResetArrow();

        StartCoroutine(FreezeYaxis(m_rigidbody));
        
        m_stoneClone = true;

        Curling(false);

        m_collider.material.staticFriction = 0; // apply friction

        m_rigidbody.useGravity = true;  //apply gravity

		ResetCurlingForce();    //reset curling force value

		m_curlingSlider.value = 0;  // curling slider value will be 0 by default

		m_arrowMaterial.SetColor("_EmissionColor", Color.black);
    }

    // Update is called once per frame
    void Update () 
    {
        Controlls();

        //Debug.Log("velocity : " + Force());
	}

    private void Controlls()
    {
        if(VJ.instance.IsTargetTaken())
        {
            MoveStone();

            Locomote();

			if (m_curlingSlider.gameObject.activeInHierarchy)
                m_curlingSlider.gameObject.SetActive(false);
            
            m_arrow.enabled = false; //Disable the arrow after the target is taken
        }
        else
        {
			ArrowController();

			//Debug.Log(m_points[0] + "  Starting Point  " + m_points[1] + "  End Point");
        }

		CurlingController();

        CurlingBehavior();

        //Debug.Log("curling :" + m_doCurling);
	}

    private void CurlingBehavior()
    {
		//if player decides to curl..
		if (IsStoneMoving() && m_doCurling && (m_curlingDiraction != 0))
		{
            //while the stone is moving forwards with certain velocity..
            if (m_rigidbody.velocity.z >= 10)
            { 
                //keep curling
                m_curlingForce += Time.deltaTime; 
            }

            //if the stone's velocity is below average velocity
            else
            {
                //reset the curling force to normal
				ResetCurlingForce();

                //turn off curling
                Curling(false);
            }

            //following will add velocity to the xaxis which will make stone move and curl towards certain point
            m_rigidbody.velocity = new Vector3
				(
                    //the xaxis will curl from current point towards the point decided by the player
                    Mathf.Lerp(m_rigidbody.velocity.x, m_curlingDiraction, (m_curlingForce * Time.deltaTime)) 
                    ,
					m_rigidbody.velocity.y
					,
					m_rigidbody.velocity.z
				);
            
			//Debug.Log("Doing Curling");
		}
    }

    //following method will curl the stone according to the slider displayed on the game scene
    private void CurlingController()
    {
        m_curlingDiraction = m_curlingSlider.value;
    }

    //following function will be used to activate and deactivate the curling behavior
    private void Curling(bool a_activator)
    {
         m_doCurling = a_activator;
    }

    //this method will reset the curling force to the default value
    private void ResetCurlingForce()
    {
        m_curlingForce = 0.35f;
    }

    //to move the arrow to take target, following method will be used
    internal void ArrowController()
    {
        m_points[1] = new Vector3(VJ.instance.m_arrowImage.transform.position.x, 0.2f, VJ.instance.m_arrowImage.transform.position.z);

        m_arrow.SetPositions(m_points);

		UpdateArrowColor();
    }

	//** following vector wil be the virtual position which will always be one step ahead of the position of the Stone,
	// making the movement of the object more smooth and realistic
    private Vector3 VirtualPosition()
	{
		return new Vector3
			(
				//getting the current x axis of the Stone, and adding +1 to the x axis.. returns one step a head of the current position of the Stone
                m_rigidbody.velocity.x + VJ.instance.GetPosition().x
				,
				//y axis will alwasy be 0, as the only directions here that are necessary are: Forward, Backward, Left and Right
				0
				,
				//getting the current z axis of the Stone, and adding +1 to the z axis.. returns one step a head of the current position of the Stone
				m_rigidbody.velocity.z + VJ.instance.GetPosition().z
			);
	}

	//following method is being used for rotating the stone
    private void Locomote()
	{
		//getting the distance between the virtual position(Which is one step a head of the current position of the Stone)
		m_targetDir = VirtualPosition() - m_rigidbody.velocity;

		//only forward, backward, left and right direction are required here
		m_dir = new Vector3(m_targetDir.x, 0, m_targetDir.z);

		// This will rotate the Object according to the controller
		transform.rotation = Quaternion.LerpUnclamped
			(
				transform.rotation, // get the current rotaiont of the Stone
				Quaternion.LookRotation(m_dir), // make Stone look towards the direction
				m_arrowRotationSpeed * Time.deltaTime    // giving it a speed to make a smooth turn/rotation
    		);
	}

    //following method will move the stone..
    private void MoveStone()
	{
        //if stone is not moving and target is not taken
        if (!m_rigidbody.velocity.Equals(Vector3.zero) && !Input.GetMouseButton(0))
        {
            //target taking behavior will stay deactivated
            VJ.instance.m_takingTarget = false;
            return;
        }

        //// This will give a push to the Object according to the controller
        m_rigidbody.AddForce(Force(), ForceMode.Impulse);
    }

    // following method will calculate the target taken by user and will apply force to the stone accordingly
    private Vector3 Force()
    {
        //getting the last arrow position and adding the force
        Vector3 _force = VJ.instance.GetPosition() * m_maxForce;

        return new Vector3
            (
                _force.x
                ,
                _force.y
	            ,
	            Mathf.Clamp(_force.z, m_minForce, m_maxForce) // the force will only be applyied on the forward moving diraction and will have a minimum and maximum limit
            );
    }

    //this method will take the last position of the stone that is thrown and will replace will a clone of a stone which will not have player controls
    private void MakeNewStone()
    {
        string a_name;

        if(IsOdd(m_turn))
        {
            a_name = "Stones_p2_Stone";
        }
        else
        {
			a_name = "Stones_p1_Stone";
        }

        Instantiate(m_fakeStone, transform.position, transform.rotation).name = a_name;
    }

	public static bool IsOdd(int value)
	{
		return value % 2 != 0;
	}

    //this method will be called when certain player is done with his/her turn..
    internal void NextTurn()
    {
        //if the stone is not collided with the borders, in the previous turn..
        if (m_stoneClone)
            MakeNewStone(); // apply and replace the player stone with the clone.

        //upon next turn, the target taking arrow will be activated
        m_arrow.enabled = true;

        transform.position = m_defaultStonePosition;

        //the animated brooms will get disabled
        m_brooms.SetActive(false);

        //camera position will be reset..
        CamManagerScript.instance.ResetCamPosition();
    }

    //follwing is being used to check whether or not the stone is moveing forward direction
    internal bool IsStoneMoving()
    {
        return m_rigidbody.velocity.z > 0.9f;
    }

    //this will check whether or not the targeting arrow is activated
    internal bool TargetingArrowActive()
    {
        return m_arrow.enabled;
    }

    //following method checks the collision between two or more objects ..
    void OnCollisionEnter(Collision a_collision)
    {
        //Debug.Log(a_collision.gameObject.name);
        
        //if stone collides with a one of the borders..
        if(a_collision.gameObject.tag.Equals("ABorder"))
        {
            //put instant stop to the stone 
            StopStone();

            //do not make clone of the stone as in the previous turn the stone hit the border
            m_stoneClone = false;

            //Diable the stone from the scene..
            VJ.instance.m_takingTarget = false;

            //reset the curling force..
			ResetCurlingForce();
        }

        //if stone collides with other sotnes..
        if (a_collision.gameObject.tag.Equals("Stone") && a_collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            //turn on the gravity of the clone stone
            a_collision.gameObject.GetComponent<Rigidbody>().useGravity = true;

            //add force to the clone stone on hit
            a_collision.gameObject.GetComponent<Rigidbody>().AddForce(a_collision.gameObject.transform.eulerAngles * (m_maxForce * m_maxForce) , ForceMode.Impulse);

            //deduct the forward moving velocity of the current player's stone by half as both stone contains the same weight..
            m_rigidbody.velocity /= 2;
        }
    }

    //following stops the stone from moving
    private void StopStone()
    {
		m_rigidbody.velocity = new Vector3(m_rigidbody.velocity.x - m_rigidbody.velocity.x, m_rigidbody.velocity.y, m_rigidbody.velocity.z - m_rigidbody.velocity.z);
        m_collider.material.staticFriction = 20;
	}

    //following function also checks the collision between two or more object, but in a different manner
    void OnTriggerEnter(Collider a_collider)
    {
        //if stone is thrown, and it passes throw certain point
        if(a_collider.gameObject.tag.Equals("StartingZone"))
        {
            //activate the animated brooms
            m_brooms.SetActive(true);

            //activate curling
            Curling(true);
        }
    }

    //following is called when there is a need of freezing certain rotation and positions of the stones
    IEnumerator FreezeYaxis(Rigidbody a_rigidbody)
    {
        yield return new WaitForSeconds(1);
        a_rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
    }

    internal void ResetArrow()
    {
        //Debug.Log("Reset Arrow");

		//by default the starting point and the end point of the arrow will be 0
        m_points[0] = m_arrowStartingPoint.position;

		//arrow ending point
        m_points[1] = new Vector3(-0.3f, 0.2f, -15.3f);

		//Debug.Log(m_points[0] + "  Starting Point  " + m_points[1] + "  End Point");
	}

    internal void UpdateArrowColor()
    {
        if (VJ.instance.GetPosition().z > 0 && VJ.instance.GetPosition().z < 0.7f)
            m_arrowMaterial.SetColor("_EmissionColor", m_averageSpeed);
        else if(VJ.instance.GetPosition().z < 0)
            m_arrowMaterial.SetColor("_EmissionColor", m_belowAverageSpeed);
        else if (VJ.instance.GetPosition().z >= 0.7f)
            m_arrowMaterial.SetColor("_EmissionColor", m_aboveAverageSpeed);           
    }

    internal void ResetStoneProperties()
    {
		m_rigidbody.constraints = RigidbodyConstraints.None;
		this.gameObject.SetActive(true);
		m_curlingForce = 0.35f;
    }
}