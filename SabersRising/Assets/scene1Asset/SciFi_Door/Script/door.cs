using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	public GameObject thedoor;

	void OnTriggerEnter()
	{
		thedoor.GetComponent<Animation> ().Play ("open");
	}
	void OnTriggerExit()
	{
		thedoor.GetComponent<Animation> ().Play ("close");
	}
}