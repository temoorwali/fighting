using UnityEngine;
using System.Collections;

public class countdown : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		StartCoroutine ("wait_4A_while");
	}
	IEnumerator wait_4A_while()
	{
		/// gate khole asset download kro 321 nh krna+++++++++++++++++++++++++++++++++++++
		transform.GetComponent<enemy_script> ().enabled = false;
		transform.GetComponent<AudioSource> ().enabled = false;
		player.transform.GetComponent<run2> ().enabled = false;
		transform.GetComponent<health_score> ().enabled = false;
		player.transform.GetComponent<fire> ().enabled = false;
		player.transform.GetComponent<start_walk> ().enabled = true;
		yield return new WaitForSeconds (8.0f);
		player.transform.GetComponent<start_walk> ().enabled = false;
		//player.transform.position =new Vector3 (player.transform.position.x,player.transform.position.y,-0.066f);
		transform.GetComponent<enemy_script> ().enabled = true;
		transform.GetComponent<AudioSource> ().enabled = true;
		player.transform.GetComponent<run2> ().enabled = true;
		transform.GetComponent<health_score> ().enabled = true;
		player.transform.GetComponent<fire> ().enabled = true;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
