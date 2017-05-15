using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManagerScript : MonoBehaviour 
{
    public static CamManagerScript instance = null;
    
    private GameObject m_stone;
    private Vector3 m_offset, m_defaultCamPosition;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Use this for initialization
    void Start()
	{
        m_defaultCamPosition = transform.position;
        
        m_stone = ControllerScript.instance.gameObject;
        
		//Calculate and store the offset value by getting the distance between the Stone's position and camera's position.
		m_offset = transform.position - m_stone.transform.position;
	}

	// LateUpdate is called after Update each frame
	void LateUpdate()
	{
        if (ControllerScript.instance.IsStoneMoving()) //&& ControllerScript.instance.enabled)

            // Set the position of the camera's transform to be the same as the Stone's, but offset by the calculated offset distance.
            transform.position = m_stone.transform.position + m_offset;
	}

    internal void ResetCamPosition()
    {
        transform.position = m_defaultCamPosition;
    }
}
