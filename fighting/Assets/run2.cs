using UnityEngine;
using System.Collections;

public class run2 : MonoBehaviour {
	//public GameObject player;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {



		transform.Translate (Vector3.forward * 6 * Time.deltaTime);
		if(Input.GetKey(KeyCode.RightArrow))
		{
		//rigidbody.MovePosition(rigidbody.position + speed * Time.deltaTime);
			transform.position = Vector3.Lerp(transform.position,transform.position + new Vector3(5,0,0), Time.deltaTime * 1);
		//transform.rigidbody.AddForce(speed);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = Vector3.Lerp(transform.position,transform.position - new Vector3(5,0,0), Time.deltaTime * 1);

		}


	}
} 
