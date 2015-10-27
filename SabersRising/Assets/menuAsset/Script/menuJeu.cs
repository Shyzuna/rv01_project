using UnityEngine;
using System.Collections;

public class menuJeu : MonoBehaviour {
	public AudioSource audio;
	void OnMouseEnter()
	{
		audio.Play ();
	}
	void OnMouseDown()
	{
		Application.LoadLevel("Scene0");
	}
}