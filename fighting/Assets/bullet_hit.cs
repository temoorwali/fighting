using UnityEngine;
using System.Collections;

public class bullet_hit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision obj)
	{
		if(obj.gameObject.tag == "enemy")
		{
			Debug.Log("hit");
			Destroy(obj.gameObject);
		}
	}
}

