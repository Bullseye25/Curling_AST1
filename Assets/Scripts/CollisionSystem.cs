using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSystem : MonoBehaviour 
{
    private Rigidbody m_rigidbody;

    void Start () 
    {
        if (GetComponent<Rigidbody>() == null)
            this.gameObject.AddComponent<Rigidbody>();

        m_rigidbody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision a_collision)
    {
        //On collision with any object, check if that object contains certain component..
        if(a_collision.gameObject.GetComponent<CollisionSystem>() != null)
        {
            // add force to the collided object
            a_collision.gameObject.GetComponent<Rigidbody>().AddForce
                       (
                           a_collision.gameObject.transform.eulerAngles 
                           * 
                           (ControllerScript.instance.m_maxForce * ControllerScript.instance.m_maxForce),
                        
                           ForceMode.Impulse
                          );

            //decrease the speed of this object
			m_rigidbody.velocity /= 2;
        }

        //if this object collides with borders
        if (a_collision.gameObject.tag.Equals("ABorder"))
        {
            //disable this gameobject
            this.gameObject.SetActive(false);
        }
    }

	internal bool IsStoneMoving()
	{
        return m_rigidbody.velocity.z > 0.7f;
	}
}

