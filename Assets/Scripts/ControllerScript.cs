using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour 
{
    public static ControllerScript instance = null;

    public GameObject m_fakeStone, m_transitionImage;

    private LineRenderer m_arrow;

    private Vector3[] m_points = new Vector3[2];

    private Vector3 m_targetDir, m_dir, m_defaultCamPosition;

    internal GameObject m_brooms;

	internal Rigidbody m_rigidbody;

    public float m_speed, m_arrowRotationSpeed;

    public bool m_useFakeStone = true;

	// Use this for initialization
	private void Awake()
	{
		if (instance == null)
			instance = this;

        m_defaultCamPosition = transform.position;

        m_brooms = GameObject.FindWithTag("Broom");
        m_brooms.SetActive(false);

        //by default the starting point and the end point of the arrow will be 0
        m_points[0] = transform.position;
		m_points[1] = transform.position;

        m_arrow = GetComponent<LineRenderer>();

        m_arrow.useWorldSpace = true;

        m_rigidbody = GetComponent<Rigidbody>();
	}

    private void OnEnable()
    {
        m_useFakeStone = true;
    }

    // Update is called once per frame
    void Update () 
    {
        Controlls();
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
        if (!m_arrow.enabled && !IsStoneMoving() && !VJ.instance.IsTargetTaken())
        {
            //Move on to next turn
            m_transitionImage.SetActive(true);
        }
	}

	private void ArrowController()
    {
        m_points[1] = VJ.instance.m_arrowImage.transform.position;
        
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
		//getting the distance between the virtual position(Whic is one step a head of the current position of the Stone) and the current position of the protagonsit
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
        m_rigidbody.AddForce(VJ.instance.GetPosition() * m_speed, ForceMode.Impulse);
	}

    internal void NextTurn()
    {
        if(m_useFakeStone)
            Instantiate(m_fakeStone, transform.position, transform.rotation);

        m_arrow.enabled = true;
        transform.position = m_defaultCamPosition;
        m_brooms.SetActive(false);
    }

    internal bool IsStoneMoving()
    {
        return m_rigidbody.velocity.z > 0;
    }

    void OnCollisionEnter(Collision a_collision)
    {
        //if stone collides with a one of the borders..
        if(a_collision.gameObject.tag.Equals("ABorder"))
        {
            m_useFakeStone = false;
            //Diable the stone from the scene.
            VJ.instance.m_takingTarget = false;
        }
    }

    void OnTriggerEnter(Collider a_collider)
    {
        if(a_collider.gameObject.tag.Equals("StartingZone"))
        {
            m_brooms.SetActive(true);
        }
    }
}
