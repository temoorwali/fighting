using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	public GameObject cam_pos_emp;
	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator>();
		//transform.Rotate (0,140,0);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.LookAt (cam_pos_emp.transform.position);
	}
}
