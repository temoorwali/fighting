using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator>();
		//transform.Rotate (0,140,0);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(player != null)
		transform.LookAt (player.transform.position);
	}
}
