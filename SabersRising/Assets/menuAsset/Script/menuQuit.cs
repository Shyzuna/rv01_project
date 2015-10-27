using UnityEngine;
using System.Collections;

public class menuQuit : MonoBehaviour {
	public AudioSource audio;
	void OnMouseEnter()
	{
		audio.Play ();
	}
	void OnMouseDown()
	{
		Application.Quit ();
	}

}
