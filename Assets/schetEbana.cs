using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schetEbana : MonoBehaviour {
	public GameObject navalny;
	public float Score = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(navalny.GetComponent<Navalny>().works){
			Score += Time.deltaTime*10;
			gameObject.GetComponent<TextMesh> ().text = ((int)Score).ToString();
		}
	}
}
