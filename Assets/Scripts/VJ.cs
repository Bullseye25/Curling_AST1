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
		if (ControllerScript.instance.IsStoneMoving() && Input.GetMouseButton(0))
		{
            m_broomAnimator.speed = 1;

			if (m_sweepingForce * Time.deltaTime < ControllerScript.instance.m_rigidbody.velocity.z)
				ControllerScript.instance.m_rigidbody.velocity = new Vector3
					(
						ControllerScript.instance.m_rigidbody.velocity.x,
						ControllerScript.instance.m_rigidbody.velocity.y,
						ControllerScript.instance.m_rigidbody.velocity.z - (m_sweepingForce * Time.deltaTime)
					);
		}

        else
        {
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

            m_inputVector = new Vector3(pos.x * (3 - 2), 0, pos.y * (3 - 0));
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
