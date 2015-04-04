using UnityEngine;
using System.Collections;

public class zomb_anim2 : MonoBehaviour {
	Animator anim;
	public GameObject player;
	//public GameObject zombie_2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//transform.Translate (Vector3.forward * 1 * Time.deltaTime);

		if(player != null &&(Vector3.Distance(player.transform.position,transform.position) < 4))
		{
			// no need in zombie2 :p
			
		}
		if(fire.fall2 == true)
		{
			//Debug.Log("pass");
			transform.GetComponent<Animator>().SetTrigger("die");
			//transform.collider.enabled=false;
			///zomb_anim.meters_inc_by_10=true;
			fire.fall2=false;
		}
	}
}
