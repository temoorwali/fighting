using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	//public GameObject aim;
	// Use this for initialization
	void Start () {
		transform.Rotate (Random.Range(10,90),0,0);
	}
	
	// Update is called once per frame
	void Update () {

	transform.Translate(Vector3.right * Time.deltaTime * 10);
		///transform.Translate (new Vector3 (60 * Time.deltaTime, 0, 0));
	}
}
