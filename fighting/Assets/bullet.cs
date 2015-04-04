using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	//public GameObject aim;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.forward * Time.deltaTime * 50);
		///transform.Translate (new Vector3 (60 * Time.deltaTime, 0, 0));
	}
}
