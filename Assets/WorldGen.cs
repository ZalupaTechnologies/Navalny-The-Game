using UnityEngine;

public class WorldGen : MonoBehaviour {

	public GameObject[] agPresets;
	public bool bOnDebug = true;
	
	//=========================================
	
	void Start()
	{
		if(bOnDebug)
			Debug.Log(gameObject.transform.name + "::WorldGen.Start()");
		
	}
	
	//=========================================
	
	void OnTriggerEnter(Collider other) {
		if(bOnDebug)
			Debug.Log(gameObject.transform.name + "::WorldGen.OnTriggerEnter() caused by " + other.gameObject.transform.name);
		System.Random rNumber = new System.Random ();
		Vector3 vNewPos = new Vector3(gameObject.transform.position.x - 80f, gameObject.transform.position.y, gameObject.transform.position.z);
		int iRandomNumber = rNumber.Next (1, agPresets.Count);
		if(bOnDebug)
			Debug.Log(gameObject.transform.name + "::WorldGen.OnTriggerEnter().iRandomNumber = " + iRandomNumber.ToString());
		Instantiate (agPresets[iRandomNumber-1], vNewPos, gameObject.transform.rotation);
	}
	
	//=========================================
	
	void OnTriggerExit(Collider other) {
		if(bOnDebug)
			Debug.Log(gameObject.transform.name + "::WorldGen.OnTriggerExit() caused by " + other.gameObject.transform.name);
		Destroy (gameObject);
	}
}
