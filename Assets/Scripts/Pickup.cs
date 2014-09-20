using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter( Collider collider)
	{
		if( collider.tag == "Player")
		{
		    Debug.Log("trigger");
			renderer.enabled = false;
		}
	}

}
