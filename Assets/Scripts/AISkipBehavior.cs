using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkipBehavior
{
    BasicBehavior,
    StrategicBehavior,
    CopyBehavior,
};


public class AISkipBehavior : MonoBehaviour 
{
	public static AISkipBehavior instance = null;

	//Needs optimization
    private MeshCollider m_collider;

    private GameObject m_brooms;

    private Rigidbody m_rigidbody;

    public SkipBehavior m_skipBehavior;

	private float m_basicForce;

	public float m_aIThinkingTime;

	private bool m_sweep = true;

    private void Awake()
    {
        if (instance == null)
            instance = this;

		m_rigidbody = GetComponent<Rigidbody>();

		m_collider = GetComponent<MeshCollider>();
    }

	void OnEnable () 
    {
//		Debug.Log("velocity : " + Force());

		m_basicForce = Random.Range (ControllerScript.instance.m_minForce, ControllerScript.instance.m_minForce + 3);

		m_collider.material.staticFriction = 0; // apply friction
		
        //PickBehavior();

		m_rigidbody.useGravity = true;  //apply gravity

		StartCoroutine(FreezeYaxis(m_rigidbody));

		ControllerScript.instance.m_stoneClone = true;

		StartCoroutine(BasicBehavior());

		VJ.instance.m_takingTarget = true;
	}
	
	void Update () 
    {
//		Debug.Log("velocity : " + Force());

		if (!m_rigidbody.velocity.Equals(Vector3.zero)) //&& !Input.GetMouseButton(0))
		{
			//target taking behavior will stay deactivated
			VJ.instance.m_takingTarget = false;
			return;
		}
		
		if (IsStoneMoving ()) 
		{
			StartCoroutine (Sweeping ());

			if (m_sweep)
				VJ.instance.Sweep ();
			else
				VJ.instance.m_broomAnimator.speed = 0;
		}
		else
		{
			VJ.instance.m_broomAnimator.speed = 0;

			ControllerScript.instance.m_arrow.enabled = false;
		}
	}
		
	private IEnumerator Sweeping()
	{
		yield return new WaitForSeconds (1.0f);

		if (m_sweep)
			m_sweep = false;
		else
			m_sweep = true;
	}

    private void PickBehavior()
    {
        int m_behavior = Random.Range(0, 3);

		switch (m_behavior)
		{
			case 0:
				m_skipBehavior = SkipBehavior.BasicBehavior;
				break;

			case 1:
				m_skipBehavior = SkipBehavior.StrategicBehavior;
				break;

			case 2:
				m_skipBehavior = SkipBehavior.CopyBehavior;
				break;

			default:
				m_skipBehavior = SkipBehavior.BasicBehavior;
				break;
		}
    }

	IEnumerator BasicBehavior()
    {
		yield return new WaitForSeconds(m_aIThinkingTime);
		if (!VJ.instance.IsTargetTaken()) 
		{       
			m_rigidbody.AddForce (Force(), ForceMode.Impulse);

			VJ.instance.m_takingTarget = false;
		}
    }

	private Vector3 Force()
	{
		return new Vector3 (Random.Range (-2.50f, 2.50f), 0, m_basicForce);
	}

	//following is called when there is a need of freezing certain rotation and positions of the stones
	IEnumerator FreezeYaxis(Rigidbody a_rigidbody)
	{
		yield return new WaitForSeconds(0.8f);
		a_rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
	}

	void OnCollisionEnter(Collision a_collision)
	{
		//Debug.Log(a_collision.gameObject.name);

		//if stone collides with a one of the borders..
		if(a_collision.gameObject.tag.Equals("ABorder"))
		{
			//put instant stop to the stone 
			StopStone();

			//do not make clone of the stone as in the previous turn the stone hit the border
			ControllerScript.instance.m_stoneClone = false;

			//Diable the stone from the scene..
			VJ.instance.m_takingTarget = false;

			//reset the curling force..
//			ResetCurlingForce();
		}

		//if stone collides with other sotnes..
		if (a_collision.gameObject.tag.Equals("Stone") && a_collision.gameObject.GetComponent<Rigidbody>() != null)
		{
			//turn on the gravity of the clone stone
			a_collision.gameObject.GetComponent<Rigidbody>().useGravity = true;

			//add force to the clone stone on hit
			a_collision.gameObject.GetComponent<Rigidbody>().AddForce(a_collision.gameObject.transform.eulerAngles * (m_basicForce) , ForceMode.Impulse);

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

	//follwing is being used to check whether or not the stone is moveing forward direction
	internal bool IsStoneMoving()
	{
		return m_rigidbody.velocity.z > 0.9f;
	}

	//
	//    private bool SceneReady()
	//    {
	//        return !TransitionScript.instance.gameObject.activeInHierarchy;
	//    }
}
