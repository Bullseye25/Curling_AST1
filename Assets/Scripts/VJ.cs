using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class VJ : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public static VJ instance = null;

	[Header("Following Will Be Taken Calculated As %")]
    public float m_sweepingForce;

    private Image m_bgImg;

    internal Image m_arrowImage;

    private Vector3 m_inputVector;

    public bool m_takingTarget = false;

	internal Animator m_broomAnimator;

    private GameObject m_home;

	private float x = 3, y = 3;// m_userInterface = 0.25f;

	public float m_arrowHeight;

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
            
//		Debug.Log(" velocity " + ControllerScript.instance.m_rigidbody.velocity.z);
//
//		Debug.Log("velocity after with sweeping  :  "+ (_calculatedSweepingForce).ToString());
    }

    private void SweepingBehavior()
    {
		if (!IsPlayerTurn ())
			return;
		
		if (WantsToSweep())
        {
			Sweep ();
        }

		//if the player is not interacting., and it's not A.I's turn
		else
        {
            //do not animate the brooms
            m_broomAnimator.speed = 0f;
		}
    }

	private bool WantsToSweep()
	{
		//check if user is pressing or Holding down the left mouse key or interacting on a touch screen
		return ControllerScript.instance.IsStoneMoving () && Input.GetMouseButton (0);
	}

	private bool IsPlayerTurn()
	{
		return ControllerScript.instance.enabled;
	}

	internal void Sweep()
	{
		//Animate Brooms
		m_broomAnimator.speed = 1;

		//if the velocity is certain level..
		if (m_sweepingForce * Time.deltaTime < ControllerScript.instance.m_rigidbody.velocity.z)
		{
			float _sweepingForceInPercent = m_sweepingForce / 100;

			float _calculatedSweepingForce = _sweepingForceInPercent + ControllerScript.instance.m_rigidbody.velocity.z;

			////decrease the amount of velocity
			ControllerScript.instance.m_rigidbody.velocity = new Vector3
				(
					Mathf.Lerp(ControllerScript.instance.m_rigidbody.velocity.x, m_home.transform.position.x, (Time.deltaTime/2)),
					ControllerScript.instance.m_rigidbody.velocity.y,
					_calculatedSweepingForce
				);
		}
	}

    public virtual void OnDrag(PointerEventData a_ped)
	{
		if (m_takingTarget || !ControllerScript.instance.TargetingArrowActive())
            return;

		ControllerScript.instance.ArrowSize (20);

		Vector2 pos;

		if (RectTransformUtility.ScreenPointToLocalPointInRectangle(m_bgImg.rectTransform, a_ped.position, a_ped.pressEventCamera, out pos))
		{
			pos.x = (pos.x / m_bgImg.rectTransform.sizeDelta.x); //+ m_userInterface);
			pos.y = (pos.y / m_bgImg.rectTransform.sizeDelta.y);// + m_userInterface);

            m_inputVector = new Vector3(pos.x * (x - 2), 0, pos.y * (y - 0));

			m_inputVector = (m_inputVector.magnitude > 1.0f) ? m_inputVector.normalized : m_inputVector;

			m_arrowImage.rectTransform.anchoredPosition = new Vector3
					
				(m_inputVector.x * 2 * (m_bgImg.rectTransform.sizeDelta.x / x),
                 
                 m_inputVector.z * 2 *(m_bgImg.rectTransform.sizeDelta.y / y) + m_arrowHeight);

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
		if (GetPosition ().z > 0) 
		{
			m_takingTarget = true;
		}

		ControllerScript.instance.ArrowSize(0);
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
