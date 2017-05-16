using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManagerScript : MonoBehaviour 
{
    public static CamManagerScript instance = null;
    
    private GameObject m_stone;
    private Vector3 m_offset, m_endrotation, m_defaultCamPosition, m_defaultCamRotation, m_broomsStartingPosition, m_broomsOffset;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Use this for initialization
    void Start()
	{
        m_broomsStartingPosition = ControllerScript.instance.m_brooms.transform.position;

        m_defaultCamPosition = transform.position;
        m_defaultCamRotation = transform.eulerAngles;
        
        m_stone = ControllerScript.instance.gameObject;
        
		//Calculate and store the offset value by getting the distance between the Stone's position and camera's position.
		m_offset = transform.position - m_stone.transform.position;

        m_broomsOffset = ControllerScript.instance.m_brooms.transform.position - m_stone.transform.position;

        m_endrotation = new Vector3(52, 0, 0);
	}

	// LateUpdate is called after Update each frame
	void LateUpdate()
	{
        if (ControllerScript.instance.IsStoneMoving())
        {
            // Set the position of the camera's transform to be the same as the Stone's, but offset by the calculated offset distance.
            transform.position = m_stone.transform.position + m_offset;
            ControllerScript.instance.m_brooms.transform.position = m_stone.transform.position + m_broomsOffset;
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, m_endrotation, Time.deltaTime);
        }   
    }

    internal void ResetCamPosition()
    {
        transform.position = m_defaultCamPosition;
        transform.eulerAngles = m_defaultCamRotation;
        ControllerScript.instance.m_brooms.transform.position = m_broomsStartingPosition;
    }
}
