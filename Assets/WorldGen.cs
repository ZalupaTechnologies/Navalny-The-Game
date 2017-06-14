using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGen : MonoBehaviour {
	public GameObject[] roads;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) {
		Debug.Log ("da");
		System.Random pizdets = new System.Random ();
		Vector3 vNewPos = new Vector3(gameObject.transform.position.x - 80f, gameObject.transform.position.y, gameObject.transform.position.z);
		int iPizdets = pizdets.Next (1, 6);
		Debug.Log (iPizdets);
		Instantiate (roads[iPizdets-1], vNewPos, gameObject.transform.rotation);
	}
	void OnTriggerExit(Collider other)
	{
		Debug.Log ("da");
		Destroy (gameObject);
	}
}
