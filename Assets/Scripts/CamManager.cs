using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour 
{
    private Transform m_camPoint, m_defaultPoint;
    public Transform m_facingPoint;

	// Use this for initialization
	void Start () 
    {
        m_camPoint = transform;
        m_defaultPoint = transform;
    }
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 a_dis = m_camPoint.position - m_facingPoint.position;

        transform.rotation = Quaternion.LookRotation(-a_dis);

        Controller();
    }

    private void Controller()
    {
        if (SwipeManager.instance.IsSwiping(SwipeDirection.Up))
        {
            ResetPosition();
            m_camPoint.position = new Vector3(m_camPoint.position.x, m_camPoint.position.y + 4, m_camPoint.position.z);
        }
        else if (SwipeManager.instance.IsSwiping(SwipeDirection.Down))
        {
            ResetPosition();
            m_camPoint.position = new Vector3(m_camPoint.position.x, m_camPoint.position.y - 4, m_camPoint.position.z);
        }

        else if (SwipeManager.instance.IsSwiping(SwipeDirection.Left))
        {
            ResetPosition();
            m_camPoint.position = new Vector3(m_camPoint.position.x + 4, m_camPoint.position.y, m_camPoint.position.z);
        }

        else if (SwipeManager.instance.IsSwiping(SwipeDirection.Right))
		{
			ResetPosition();
			m_camPoint.position = new Vector3(m_camPoint.position.x - 4, m_camPoint.position.y, m_camPoint.position.z);
		}
    }

    private void ResetPosition()
    {
        m_camPoint.position = m_defaultPoint.position;
    }
}
