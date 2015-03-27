using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class player_kill : MonoBehaviour {
	public Camera cam;
	public GameObject cam_pos_empty;
	public  GameObject player;
	//public static bool stop_enemy_script;
	//public GameObject manager;
	public Light blood_light_;
	// Use this for initialization
	void Start () {

//	    blood_light_.enabled = false;
	}
	 
	IEnumerator blood()
	{
		blood_light_.enabled = true;
		yield return new WaitForSeconds (0.3f);
		blood_light_.enabled = false;
	}
	// Update is called once per frame
	void FixedUpdate () {

						//if (Vector3.Distance (transform.position, player.transform.position) < 1.0f) 
			            {
						  //StartCoroutine ("blood");
						
		                }
	}
	void OnCollisionEnter(Collision obj)
	{
		if (obj.gameObject.tag == "player") 
		{
			health_score.health --;
			//stop_enemy_script=true;
			if(health_score.health == 0 )
			{
			Destroy(obj.gameObject);
			//cam.transform.position = cam_pos_empty.transform.position + new Vector3(5,5,5);
			}

		}
	}
}
