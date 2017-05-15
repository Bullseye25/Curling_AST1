using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class VJ : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public static VJ instance = null;

    public float m_sweepingForce;

    private Image m_bgImg;

    internal Image m_arrowImage;

    private Vector3 m_inputVector;

    public bool m_takingTarget = false;

    private Animator m_broomAnimator;

    private void Start()
    {
        if (instance == null)
            instance = this;
        
        m_bgImg = GetComponent<Image>();

        m_arrowImage = transform.GetChild(0).GetComponent<Image>();

        m_inputVector = Vector3.zero;

        m_broomAnimator = ControllerScript.instance.m_brooms.GetComponent<Animator>();
    }

    private void Update()
    {
        SweepingBehavior();
    }

    private void SweepingBehavior()
    {
        //check if user is pressing or Holding down the left mouse key or interacting on a touch screen
        if (ControllerScript.instance.IsStoneMoving() && Input.GetMouseButton(0))
        {
            //Animate Brooms
            m_broomAnimator.speed = 1;

            //if the velocity is certain level..
            if (m_sweepingForce * Time.deltaTime < ControllerScript.instance.m_rigidbody.velocity.z)
            {
                ////decrease the amount of velocity
                ControllerScript.instance.m_rigidbody.velocity = new Vector3
                    (
                        ControllerScript.instance.m_rigidbody.velocity.x,
                        ControllerScript.instance.m_rigidbody.velocity.y,
                        ControllerScript.instance.m_rigidbody.velocity.z - (m_sweepingForce * Time.deltaTime)   // decrease the forward moving velocity
                    );

                //if the stone is too slippery
                if (IsStoneTooSlippery())
                {
                    Debug.Log(ControllerScript.instance.m_collider.material.dynamicFriction);

                    //** decrease the friction **//
                    //subtracting the amount to the friction will make the surface of the floor smooth 
                    ControllerScript.instance.m_collider.material.dynamicFriction -= Time.deltaTime;
                }
            }
        }

        //if the player is not interacting..
        else
        {
            //do not animate the brooms
            m_broomAnimator.speed = 0f;
		}
    }

    public virtual void OnDrag(PointerEventData a_ped)
	{
        if (m_takingTarget)
            return;

		Vector2 pos;

		if (RectTransformUtility.ScreenPointToLocalPointInRectangle(m_bgImg.rectTransform, a_ped.position, a_ped.pressEventCamera, out pos))
		{
			pos.x = (pos.x / m_bgImg.rectTransform.sizeDelta.x);
			pos.y = (pos.y / m_bgImg.rectTransform.sizeDelta.y);

            m_inputVector = new Vector3(pos.x * (3 - 0), 0, pos.y * (3 - 0.5f));
			m_inputVector = (m_inputVector.magnitude > 1.0f) ? m_inputVector.normalized : m_inputVector;

			m_arrowImage.rectTransform.anchoredPosition = new Vector3
                (m_inputVector.x * (m_bgImg.rectTransform.sizeDelta.x / 3),
                 
                 m_inputVector.z * (m_bgImg.rectTransform.sizeDelta.y / 3));
		}
	}

	public virtual void OnPointerDown(PointerEventData a_ped)
	{
		OnDrag(a_ped);
	}

	public virtual void OnPointerUp(PointerEventData a_ped)
	{
        if(GetPosition().z > 0)
            m_takingTarget = true;

        //StartCoroutine(ResetPointer());
	}

    internal Vector3 GetPosition()
	{
        return new Vector3(m_inputVector.x, m_inputVector.y, Mathf.Clamp(m_inputVector.z, 0.25f, 1));
	}

    internal bool IsTargetTaken()
    {
        return m_takingTarget;
    }

    internal bool IsStoneTooSlippery()
    {
        return ControllerScript.instance.m_collider.material.dynamicFriction >= 0.5f;
    }

    IEnumerator ResetPointer()
    {
        yield return new WaitForSeconds(1);

        m_inputVector = Vector3.zero;
    }
}
