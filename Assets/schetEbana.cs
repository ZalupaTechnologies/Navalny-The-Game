using System.Collections;
using System.Collections.Generic;
using System.IO;
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

	public void yobanniVRotTiProebal()
	{
		if (!File.Exists ("schet.yoba")) {
			using (StreamWriter sw = File.CreateText ("schet.yoba")) {
				sw.WriteLine (((int)Score).ToString ());
			}	
		} else {
			File.WriteAllText(@"schet.yoba",string.Empty); //chistim
			File.WriteAllText(@"schet.yoba", ((int)Score).ToString ()); //megagovnokod
		}
	}
}
