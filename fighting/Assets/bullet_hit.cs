using UnityEngine;
using System.Collections;

public class bullet_hit : MonoBehaviour {
	public static bool fall1;
	public static bool fall2;
	// Use this for initialization
	void Start () {
		fall1 = false;
		fall2 = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision obj)
	{
		if(obj.gameObject.tag == "enemy")
		{
			Debug.Log("hitting1");
			Destroy(obj.gameObject);
			//fall1=true;
//			enemy_script.enemies_1.transform.GetComponent<Animator>().SetTrigger("hit");
		}
		if (obj.gameObject.tag == "enemy2") 
		{
			//fall2=true;
			Debug.Log("hitting2");
			Destroy(obj.gameObject);
		}
	}
}

