using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class gdeSchetAVotOn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<TextMesh> ().text = File.ReadAllText("schet.yoba");
	}
	
	void OnGUI() {
			if (GUI.Button (new Rect (Screen.width/2-50, Screen.height/2-25, 100, 50), "Restart"))
				Application.LoadLevel ("runner");
			
			}
}
