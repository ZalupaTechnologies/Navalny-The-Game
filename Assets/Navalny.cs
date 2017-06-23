using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navalny : MonoBehaviour {
	public float speed = 1;
	public float fDelitel = 3;
	public bool works = true;
	public int row = 2;
	public bool hasRecentlyChanged = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (works) { 
			#region новое
			/*
			speed += Time.deltaTime / fDelitel;
			//Придание импульса Навальному
			GameObject nav = GameObject.Find("navalny");
			nav.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
			//gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * speed); <-- не работает
			//Следование
			transform.position = new Vector3(nav.transform.position.x+5, transform.position.y, nav.transform.position.z);
			if(Input.GetKeyDown (KeyCode.LeftArrow))
			{
				nav.GetComponent<Rigidbody>().AddForce(new Vector3(0f,0f,-40f));
			}
			else if(Input.GetKeyDown (KeyCode.RightArrow))
			{
				nav.GetComponent<Rigidbody>().AddForce(new Vector3(0f,0f,40f));
			}
			else if(Input.GetKeyDown (KeyCode.Space))
			{
				nav.GetComponent<Rigidbody>().AddForce (new Vector3(0f,50f,0f));
			}
			Всё новое хорошо забытое старое
			*/
			#endregion
			#region старое
			#region реворк
			GameObject nav = GameObject.Find("navalny");
			nav.transform.RotateAround(nav.transform.position, Vector3.forward, 100 * speed * Time.deltaTime);
			#endregion

			speed += Time.deltaTime / 3;
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				if (row - 1 > 0) {
					row--;
					hasRecentlyChanged = true;
				}
			}
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				if (row + 1 < 4) {
					row++;
					hasRecentlyChanged = true;
				}
			}
			transform.position += Vector3.left * Time.deltaTime * speed;
			transform.position = new Vector3 (transform.position.x, 5.875374f, transform.position.z);
			switch (row) {
			case 1:
				if (hasRecentlyChanged) {
					hasRecentlyChanged = false;
					transform.position = Vector3.MoveTowards (transform.position, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, -2f), 10);
				}
				break;
			case 2:
				if (hasRecentlyChanged) {
					hasRecentlyChanged = false;
					transform.position = Vector3.MoveTowards (transform.position, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, 0f), 10);
				}
				break;
			case 3:
				if (hasRecentlyChanged) {
					hasRecentlyChanged = false;
					transform.position = Vector3.MoveTowards (transform.position, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, 2f), 10);
				}
				break;
			}
			#endregion
		}
		else  {
			GameObject.Find ("Schet").GetComponent<schetEbana> ().yobanniVRotTiProebal ();
			Application.LoadLevel ("progral");
		}
	}
	void OnGUI()
	{
		/*if (!works) {
			if (GUI.Button (new Rect (Screen.width/2-50, Screen.height/2-25, 100, 50), "Restart"))
				Application.LoadLevel (Application.loadedLevel);
			
		}*/
	}
}
