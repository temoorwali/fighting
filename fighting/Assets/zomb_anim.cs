using UnityEngine;
using System.Collections;

public class zomb_anim : MonoBehaviour {
	Animator anim;
	public GameObject player;
	public static bool meters_inc_by_10=false;
	public static int zombie_counter;
	// Use this for initialization
	void Start () {
		zombie_counter = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(player != null &&(Vector3.Distance(player.transform.position,transform.position) < 4))
		{

		transform.GetComponent<Animator> ().SetTrigger ("attack");
		}

		if (player != null && (Vector3.Distance (player.transform.position, transform.position) < 3)) 
		{
						this.GetComponent<AudioSource> ().enabled = true;
				}

		if(fire.fall1 == true)
		{
			//zombie_counter++;

			transform.GetComponent<Animator>().SetTrigger("hit");
			//transform.collider.enabled=false;
		///////////////////	meters_inc_by_10=true;
			fire.fall1=false;

		}
	}
}
