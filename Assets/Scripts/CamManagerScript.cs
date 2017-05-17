using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManagerScript : MonoBehaviour 
{
    public static CamManagerScript instance = null;

    public float m_maxTopDown;
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
        //getting the default position of the brooms
        m_broomsStartingPosition = ControllerScript.instance.m_brooms.transform.position;

        //getting the default position of the camera
        m_defaultCamPosition = transform.position;

        //getting the default rotaiton of the camera
        m_defaultCamRotation = transform.eulerAngles;

        //getting the stone..
        m_stone = ControllerScript.instance.gameObject;
        
		//Calculate and store the offset value by getting the distance between the Stone's position and camera's position.
		m_offset = transform.position - m_stone.transform.position;

		//Calculate and store the offset value by getting the distance between the Stone's position and brooms position.
		m_broomsOffset = ControllerScript.instance.m_brooms.transform.position - m_stone.transform.position;

        //following vector will be used to rotate the camera to give a better view to the player when stone is moving
        m_endrotation = new Vector3(m_maxTopDown, 0, 0);
	}

	// LateUpdate is called after Update each frame
	void LateUpdate()
	{
        if (ControllerScript.instance.IsStoneMoving())
        {
            // Set the position of the camera's transform to be the same as the Stone's, but offset by the calculated offset distance.
            transform.position = m_stone.transform.position + m_offset;

            //move the brooms along with the stone..
            ControllerScript.instance.m_brooms.transform.position = m_stone.transform.position + m_broomsOffset;
           
            //slowly turn the camera to give a better view while stone is moving..
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
