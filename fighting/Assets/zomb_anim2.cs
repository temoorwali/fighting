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

		transform.Translate (Vector3.forward * 1 * Time.deltaTime);

		if(player != null &&(Vector3.Distance(player.transform.position,transform.position) < 4))
		{
			//transform.GetComponent<Animator> ().SetTrigger ("attack");
			//anim.SetTrigger ("attack");
			//ScriptableObject race=gameObject.GetComponent<fire>();
			
		}
		if(fire.fall == true)
		{
			//Debug.Log("pass");
			transform.GetComponent<Animator>().SetTrigger("die");
			transform.collider.enabled=false;
			//Destroy(enemy_script.enem_2,0.1f);
			fire.fall=false;
		}
	}
}
