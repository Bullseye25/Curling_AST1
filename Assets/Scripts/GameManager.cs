using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    public static GameManager instance = null;

    public List<GameObject> m_stones = new List<GameObject>();

    public GameObject m_transitionImage;

	public Sprite m_sound, m_mute, m_pause, m_unpause;

	private void Awake()
    {
        if (instance == null)
            instance = this;

        m_transitionImage.GetComponent<TransitionScript>().Awake();
    }

    // Update is called once per frame
    void Update ()
    {
        if(AreAnyStonesMoving())
        {
            m_transitionImage.SetActive(true); // do the transition & //Move on to next turn
		}
	}

    private bool StonesMoving()
    {
        foreach (GameObject _stone in GameObject.FindGameObjectsWithTag("Stone")) // get all the stones in the scene
        {
            if(!m_stones.Contains(_stone))  // if certain stone is not already in the list
				m_stones.Add(_stone);   //add that stone to the list
            
			if(_stone.GetComponent<ControllerScript>() != null)// && _stone.GetComponent<ControllerScript> ().enabled) //if the stone contain player controls script
            {
				//check if that stone is moving or not
				if (_stone.GetComponent<ControllerScript> ().IsStoneMoving ()) 
				{ 
					return true;
				}
            }

			else if(_stone.GetComponent<AISkipBehavior>() != null) //&& _stone.GetComponent<AISkipBehavior> ().enabled) //if the stone contain player controls script
			{
				//check if that stone is moving or not
				if (_stone.GetComponent<AISkipBehavior> ().IsStoneMoving ()) 
				{ 
					return true;
				} 
			}

            else //if stone does not contain player controls script..
            {
                if (_stone.GetComponent<CollisionSystem>().IsStoneMoving()) //get the collision system and chech if that stone is moving or not
                    return true;    //return true, if stone is moving
            }
        }

        return false;   //return false if none of the stones are moving
    }

    private bool AreAnyStonesMoving()
    {
//		Debug.Log (StonesMoving() +" StonesMoving");
//		Debug.Log (ControllerScript.instance.TargetingArrowActive()+" TargetingArrowActive()");
//		Debug.Log (VJ.instance.IsTargetTaken()+" IsTargetTaken");
		
        return 
            (
                !StonesMoving() //check all stones that they are stop
                &&
                !ControllerScript.instance.TargetingArrowActive() //check if the targeting arrow is inactive
                &&
                !VJ.instance.IsTargetTaken()// check if the target is taken and the player's turn is over.
            );
    }

	public void ExitButton()
	{
        ExitScript.EndUnityButtonTouched();
	}

	public void OnPressContinue()
	{
		ControllerScript.instance.enabled = true;
		VJ.instance.enabled = true;

//		Debug.Log ("controller: "+ ControllerScript.instance.enabled);
//		Debug.Log ("VJ: "+ VJ.instance.enabled);

	}

	public void OnPressAudio(Image m_image)
	{
		if(m_image.sprite == m_sound)
		{
			AudioCompiler (1,0);
			
			m_image.sprite = m_mute;
		}
		else
		{
			AudioCompiler (0,1);
			
			m_image.sprite = m_sound;
		}
	}

	private void AudioCompiler(float a_checkTheAmountOfVolume, float a_finalizedVolumeValue)
	{
		foreach (AudioSource a_audio  in GameObject.FindObjectsOfType<AudioSource>())
		{
			if(a_audio.volume == a_checkTheAmountOfVolume)
			{
				a_audio.volume = a_finalizedVolumeValue;
			}
		}	
	}

	public void OnPressPause(Image m_image)
	{
		//if user press play
		if(m_image.sprite == m_unpause)
		{
			//unfreeze the game
			Time.timeScale = 1;

			//enable playercontrols
			VJ.instance.enabled = true;

			//enable the curling slider
			ControllerScript.instance.m_curlingSlider.enabled = true;

			//change the icon to pause
			m_image.sprite = m_pause;
		}

		//if user press pause
		else
		{
			//freeze the game
			Time.timeScale = 0;			

			//disable the player controls
			VJ.instance.enabled = false;

			//disable the slider
			ControllerScript.instance.m_curlingSlider.enabled = false;

			//change the icon to play
			m_image.sprite = m_unpause;
		}
	}
}
