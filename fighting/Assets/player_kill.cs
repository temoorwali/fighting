using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class player_kill : MonoBehaviour {
	public Camera cam;
	//public GameObject cam_pos_empty;
	public  GameObject player;
	public static bool stop_enemy_script = false;
	public GameObject manager;
	public Light blood_light_;
	// Use this for initialization
	void Start () {



	}
	 
	IEnumerator blood()
	{
		blood_light_.enabled = true;
		yield return new WaitForSeconds (0.3f);
		blood_light_.enabled = false;
	}
	// Update is called once per frame
	void FixedUpdate () {

						if (player == null) 
			            {
			//manager.GetComponent<enemy_script>().enabled=false;

						
		                }
	}

	IEnumerator wait()
	{
		//Debug.Log("enum");
		manager.GetComponent<AudioSource> ().enabled = false;
		yield return new WaitForSeconds (1.0f);
		Application.LoadLevel("Total score");
	}
	void OnCollisionExit(Collision obj)
	{
		if (obj.gameObject.tag == "player") 
		{

			health_score.health --;
			StartCoroutine("blood");
			if(health_score.health == 0 )
			{
			Destroy(obj.gameObject);
				StartCoroutine("wait");
				//stop_enemy_script = true;
			//cam.transform.position = cam_pos_empty.transform.position + new Vector3(5,5,5);
			}

		}
	}
}
