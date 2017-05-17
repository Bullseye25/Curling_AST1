using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionScript : MonoBehaviour 
{
    //following mehtod will be called whenever there is a need to reset the properties of the stone
    public void ActiveController(int a_activationValue)
    {
        //if there is a new turn is over..
        if (a_activationValue >= 1)
        {
            //reset the properties of the stone to default, placing the stone to the starting position..
            ControllerScript.instance.ResetStoneProperties();
        }

        //if the turn is over..
        else
        {
            //disable the controls and the stone..
            ControllerScript.instance.gameObject.SetActive(false);

        }
    }

    public void NextTurn()
    {
		ControllerScript.instance.NextTurn();

    }

    //following disables the transition..
    public void TransitionDisabler()
    {
        this.gameObject.SetActive(false);
    }

}
