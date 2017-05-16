using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
    public static GameManager instance = null;

    public List<GameObject> m_stones = new List<GameObject>();

    public GameObject m_transitionImage;

    private void Awake()
    {
        if (instance = null)
            instance = this;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(!StonesMoving() //check all stones that they are stop
           &&
           !ControllerScript.instance.TargetingArrowActive() //check if the targeting arrow is inactive
           &&
           !VJ.instance.IsTargetTaken()// check if the target is taken and the player's turn is over.
          )
        {
            m_transitionImage.SetActive(true); // do the transition & //Move on to next turn
		}
	}

    private bool StonesMoving()
    {
        foreach (GameObject _stone in GameObject.FindGameObjectsWithTag("Stone"))
        {
            if(!m_stones.Contains(_stone))
				m_stones.Add(_stone);
            
            if(_stone.GetComponent<CollisionSystem>() != null)
            {
                if (_stone.GetComponent<CollisionSystem>().IsStoneMoving())
                    return true;
                
            }
            else if(_stone.GetComponent<ControllerScript>() != null)
            {
                if (_stone.GetComponent<ControllerScript>().IsStoneMoving())
                    return true;
            }
        }

        return false;
    }
}
