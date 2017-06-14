using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideEbat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider e)
	{
			Debug.Log ("gameover ebat))");
			e.transform.root.gameObject.GetComponent<Navalny> ().works = false;
			e.gameObject.GetComponent<Rigidbody> ().useGravity = true;
	}
}
