using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionScript : MonoBehaviour 
{
    public void ActiveController(int a_activationValue)
    {
        if (a_activationValue >= 1)
        {
            ControllerScript.instance.m_rigidbody.constraints = RigidbodyConstraints.None;
            ControllerScript.instance.gameObject.SetActive(true);
        }
        else
        {
            ControllerScript.instance.gameObject.SetActive(false);
        }
    }

    public void NextTurn()
    {
		ControllerScript.instance.NextTurn();
    }

    public void TransitionDisabler()
    {
        this.gameObject.SetActive(false);
    }
}
