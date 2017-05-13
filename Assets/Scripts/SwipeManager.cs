using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SwipeDirection
{
	None = 0,
	Left = 1,
	Right = 2,
	Up = 4,
	Down = 8,
}

public class SwipeManager : MonoBehaviour 
{
    public static SwipeManager instance = null;
    
    public SwipeDirection direction { set; get; }
    
    private Vector3 touchPosition;
    private float swipeResistanceX = 50f;
    private float swipeResistanceY = 100f;

    private void Start()
    {
        if (instance == null)
            instance = this;
    }

    // Update is called once per frame
    private void Update () 
    {
        direction = SwipeDirection.None;
        
        if(Input.GetMouseButtonDown(0))
        {
            touchPosition = Input.mousePosition;   
        }

        if(Input.GetMouseButtonUp(0))
        {
            Vector2 deltaSwipe = touchPosition - Input.mousePosition;

            if(Mathf.Abs(deltaSwipe.x) > swipeResistanceX)
            {
                direction |= (deltaSwipe.x < 0) ? SwipeDirection.Right : SwipeDirection.Left;
            }

			if (Mathf.Abs(deltaSwipe.y) > swipeResistanceY)
			{
                direction |= (deltaSwipe.y < 0) ? SwipeDirection.Up : SwipeDirection.Down;
			}
        }
	}

    internal bool IsSwiping(SwipeDirection a_swipeDirection)
    {
        return direction == a_swipeDirection;
    }
}
