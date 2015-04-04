using UnityEngine;
using System.Collections;

public class start_walk : MonoBehaviour {
	public GameObject wall;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.forward * 1 * Time.deltaTime);
	}
	void OnCollisionEnter(Collision hit_wall)
	{
		if (hit_wall.gameObject.tag == "wall") 
		{
			Debug.Log("hit the wall");
			this.transform.GetComponent<start_walk>().enabled=false;
			this.transform.GetComponent<Animator>().SetTrigger("hit_wall");
			wall.transform.GetComponent<Animator>().SetTrigger("hit_wall");
			wall.audio.Play();
		}
	}
}
