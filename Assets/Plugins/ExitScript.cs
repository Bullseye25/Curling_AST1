using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class ExitScript 
{
	/* Interface to native implementation */

	[DllImport("__Internal")]
	private static extern void _EndUnityButtonTouched();

//	[DllImport("__Internal")]
//	private static extern void _PauseState();
//
	// Starts lookup for some bonjour registered service inside specified domain
    public static void EndUnityButtonTouched()
	{
		Debug.Log("Unity button is working");
        
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor)
			_EndUnityButtonTouched();
	}

//	public static void PauseState()
//	{
//		if (Time.timeScale.Equals (1))
//			Time.timeScale = 0;
//		else
//			Time.timeScale = 1;
//	}
}
