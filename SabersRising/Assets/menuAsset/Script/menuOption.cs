using UnityEngine;
using System.Collections;

public class menuOption : MonoBehaviour {
	public AudioSource audio;

	void OnMouseEnter()
	{
		audio.Play ();
	}
	void OnMouseDown()
	{
		Application.LoadLevel("Options");
	}
}
