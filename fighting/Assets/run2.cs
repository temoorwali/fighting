using UnityEngine;
using System.Collections;

public class run2 : MonoBehaviour {
	public Camera player_cam;
	// Use this for initialization
	void Start () {
		//Screen.showCursor = false;
		//Screen.lockCursor = true;
	}

	IEnumerator cam_wait()
	{
		yield return new WaitForSeconds (0.2f);
		this.player_cam.enabled = true;
	}
	// Update is called once per frame
	void FixedUpdate () {
		StartCoroutine ("cam_wait");
		this.transform.GetComponent<Animator> ().SetTrigger ("start_run");
		transform.Translate (Vector3.forward * 3 * Time.deltaTime);
		if(Input.GetKey(KeyCode.RightArrow))
		{
		
			transform.position = Vector3.Lerp(transform.position,transform.position + new Vector3(5,0,0), Time.deltaTime * 1);
		//transform.rigidbody.AddForce(speed);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = Vector3.Lerp(transform.position,transform.position - new Vector3(5,0,0), Time.deltaTime * 1);

		}


	}
} 
