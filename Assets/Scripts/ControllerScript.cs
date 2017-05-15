using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour 
{
    public static ControllerScript instance = null;

    public GameObject m_fakeStone, m_transitionImage;

    private LineRenderer m_arrow;

    public Transform m_arrowStartingPoint;

    private Vector3[] m_points = new Vector3[2];

    private Vector3 m_targetDir, m_dir, m_defaultCamPosition;

    internal MeshCollider m_collider;

    internal GameObject m_brooms;

	internal Rigidbody m_rigidbody;

    public float m_force, m_arrowRotationSpeed;

    public bool m_useFakeStone = true;

	// Use this for initialization
	private void Awake()
	{
		if (instance == null)
			instance = this;

        m_defaultCamPosition = transform.position;

        m_brooms = GameObject.FindWithTag("Broom");

        m_brooms.SetActive(false);

        m_arrow = GetComponent<LineRenderer>();

        m_arrow.useWorldSpace = true;

        m_rigidbody = GetComponent<Rigidbody>();

        m_collider = GetComponent<MeshCollider>();
	}

    private void OnEnable()
    {
        //reset the rotation
        transform.eulerAngles = Vector3.zero;
        
        ////arrow starting point
        Vector3 a_startingPointOfArrow = new Vector3(m_arrowStartingPoint.position.x, m_arrowStartingPoint.position.y + 1.5f, m_arrowStartingPoint.position.z);

        //by default the starting point and the end point of the arrow will be 0
        m_points[0] = a_startingPointOfArrow;

        //arrow ending point
		m_points[1] = transform.position * 2;

        StartCoroutine(FreezeYaxis(m_rigidbody));
        
        m_useFakeStone = true;

        m_collider.material.dynamicFriction = 0; // apply friction

        m_rigidbody.useGravity = true;
    }

    // Update is called once per frame
    void Update () 
    {
        Controlls();

        Debug.Log("velocity : "+ VJ.instance.GetPosition() * m_force);
	}

    private void Controlls()
    {
        if(VJ.instance.IsTargetTaken())
        {
            MoveStone();

            Locomote();

            m_arrow.enabled = false; //Disable the arrow after the target is taken
        }

		ArrowController();

        ////When Turn is over
        if (!m_arrow.enabled && !IsStoneMoving() && !VJ.instance.IsTargetTaken()) //&& !InTransitionPhase())
        {
            //Move on to next turn
            m_transitionImage.SetActive(true);
        }
	}

	private void ArrowController()
    {
        m_points[1] = new Vector3(VJ.instance.m_arrowImage.transform.position.x, 0.5f, VJ.instance.m_arrowImage.transform.position.z);

        m_arrow.SetPositions(m_points);
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

    private void MoveStone()
	{
        if (!m_rigidbody.velocity.Equals(Vector3.zero) && !Input.GetMouseButton(0))
        {
            VJ.instance.m_takingTarget = false;
            return;
        }

        //// This will give a push to the Object according to the controller
        m_rigidbody.AddForce((VJ.instance.GetPosition() * m_force), ForceMode.Impulse);
	
    }

    private void MakeNewStone()
    {
        Instantiate(m_fakeStone, transform.position, transform.rotation);
    }

    internal void NextTurn()
    {
        if (m_useFakeStone)
            MakeNewStone();
        
        m_arrow.enabled = true;
        transform.position = m_defaultCamPosition;
        m_brooms.SetActive(false);
        CamManagerScript.instance.ResetCamPosition();
    }

    internal bool IsStoneMoving()
    {
        return m_rigidbody.velocity.z > 0;
    }

    internal bool InTransitionPhase()
    {	
        return m_transitionImage.gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsTag("Transition");
    }

    void OnCollisionEnter(Collision a_collision)
    {
        Debug.Log(a_collision.gameObject.name);
        
        //if stone collides with a one of the borders..
        if(a_collision.gameObject.tag.Equals("ABorder") && IsStoneMoving())
        {
            StopStone();
            
            m_useFakeStone = false;

            //Diable the stone from the scene.
            VJ.instance.m_takingTarget = false;
        }

        if (a_collision.gameObject.tag.Equals("Stone") && a_collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            //turn on gravity of the stone
            a_collision.gameObject.GetComponent<Rigidbody>().useGravity = true;

            //add force to the stone on hit
            a_collision.gameObject.GetComponent<Rigidbody>().AddForce(a_collision.gameObject.transform.eulerAngles * (m_force * m_force) , ForceMode.Impulse);

            //deduct the velocity of the current player's stone by half as both stone contains the same weight..
            m_rigidbody.velocity /= 2;
        }
    }

    private void StopStone()
    {
		m_rigidbody.velocity = new Vector3(m_rigidbody.velocity.x, m_rigidbody.velocity.y, m_rigidbody.velocity.z);
        m_collider.material.dynamicFriction = 20;
	}

    void OnTriggerEnter(Collider a_collider)
    {
        if(a_collider.gameObject.tag.Equals("StartingZone"))
        {
            m_brooms.SetActive(true);
        }
    }

    IEnumerator FreezeYaxis(Rigidbody a_rigidbody)
    {
        yield return new WaitForSeconds(1);
        a_rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
    }
}