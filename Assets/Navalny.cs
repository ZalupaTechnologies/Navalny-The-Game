using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navalny : MonoBehaviour {
	public float speed = 1;
	public bool works = true;
	public int row = 2;
	public bool hasRecentlyChanged = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (works) {
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
		}
	}
	void OnGUI()
	{
		if (!works) {
			if (GUI.Button (new Rect (Screen.width/2-50, Screen.height/2-25, 100, 50), "Restart"))
				Application.LoadLevel (Application.loadedLevel);
			
		}
	}
}
