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

    private GameObject m_home;

    private float x = 3, y = 3, m_arrowHeight = 5, m_userInterface = 0.25f;

    private void Start()
    {
        if (instance == null)
            instance = this;
        
        m_bgImg = GetComponent<Image>();

        m_arrowImage = transform.GetChild(0).GetComponent<Image>();

        m_inputVector = Vector3.zero;

        m_broomAnimator = ControllerScript.instance.m_brooms.GetComponent<Animator>();

        m_home = GameObject.Find("Home2");
    }

    private void Update()
    {
        SweepingBehavior();
            

		//Debug.Log(" velocity " + ControllerScript.instance.m_rigidbody.velocity);
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
                        //ControllerScript.instance.m_rigidbody.velocity.x,
                        Mathf.Lerp(ControllerScript.instance.m_rigidbody.velocity.x, m_home.transform.position.x, (Time.deltaTime/2)),
                        ControllerScript.instance.m_rigidbody.velocity.y,

                        Mathf.Lerp(ControllerScript.instance.m_rigidbody.velocity.z, m_home.transform.position.z, (0.001f))
						//ControllerScript.instance.m_rigidbody.velocity.z - (m_sweepingForce * Time.deltaTime)  // reduce the friction
					);
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

        ControllerScript.instance.m_arrow.startWidth = 6;
        ControllerScript.instance.m_arrow.endWidth = 6;

		Vector2 pos;

		if (RectTransformUtility.ScreenPointToLocalPointInRectangle(m_bgImg.rectTransform, a_ped.position, a_ped.pressEventCamera, out pos))
		{
			pos.x = (pos.x / m_bgImg.rectTransform.sizeDelta.x);
			pos.y = (pos.y / m_bgImg.rectTransform.sizeDelta.y + m_userInterface);

            m_inputVector = new Vector3(pos.x * (x - 0), 0, pos.y * (y - 0));

            //Debug.Log("Before Adjustment: " + m_inputVector);

			m_inputVector = (m_inputVector.magnitude > 1.0f) ? m_inputVector.normalized : m_inputVector;

            //Debug.Log("After Adjustment: " + m_inputVector);

			m_arrowImage.rectTransform.anchoredPosition = new Vector3
                (m_inputVector.x * (m_bgImg.rectTransform.sizeDelta.x / x),
                 
                 m_inputVector.z * 2 * (m_bgImg.rectTransform.sizeDelta.y / y) + m_arrowHeight);

            var width = ControllerScript.instance.m_arrow.bounds;
            width.size = m_inputVector;
		}
	}

	public virtual void OnPointerDown(PointerEventData a_ped)
	{
		OnDrag(a_ped);
	}

	public virtual void OnPointerUp(PointerEventData a_ped)
	{
        if (GetPosition().z > 0)
            m_takingTarget = true;

		ControllerScript.instance.m_arrow.startWidth = 0;
		ControllerScript.instance.m_arrow.endWidth = 0;
	}

    internal Vector3 GetPosition()
	{
        return m_inputVector;
	}

    internal bool IsTargetTaken()
    {
        return m_takingTarget;
    }
}
