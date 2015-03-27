using UnityEngine;
using System.Collections;

public class zomb_anim : MonoBehaviour {
	Animator anim;
	public GameObject player;
	//public GameObject zombie;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(player != null &&(Vector3.Distance(player.transform.position,transform.position) < 4))
		{
		transform.GetComponent<Animator> ().SetTrigger ("attack");
		}
		if(fire.fall == true)
		{
			transform.GetComponent<Animator>().SetTrigger("hit");
			transform.collider.enabled=false;
			///Destroy(this.gameObject,0.2f);
			fire.fall=false;
		}
	}
}
