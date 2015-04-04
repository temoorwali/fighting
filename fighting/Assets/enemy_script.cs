using UnityEngine;
using System.Collections;

public class enemy_script : MonoBehaviour {
	public GameObject enemies_1;
	public GameObject enemies_2;
	public GameObject enemies_3;
	public GameObject player;
	GameObject enem_rand;
	GameObject enem_1;
	GameObject enem_2;
	GameObject enem_3;
	public GameObject manager;
	int a;
	// Use this for initialization
	IEnumerator wait()
	{
		yield return new WaitForSeconds (9.0f);
		Debug.Log ("enemy_start");
		InvokeRepeating ("inst1", 1.0f, 1.0f);
		InvokeRepeating ("inst2", 1.0f, 3.0f);
		InvokeRepeating ("inst3", 1.0f, 3.0f);
		InvokeRepeating ("inst_rand", 1.0f, 2.5f);
	}
	void Start () 
	{
		StartCoroutine ("wait");
	}

	void inst1()
	{
		if(player != null)
		enem_1=(GameObject)	Instantiate (enemies_1, new Vector3 (Random.Range (player.transform.position.x + 7, player.transform.position.x - 7), 6.2758f, player.transform.position.z + 7), Quaternion.identity);
	}
	void inst2()
	{
		if(player != null)
		enem_2=(GameObject)	Instantiate (enemies_2, new Vector3 (Random.Range (player.transform.position.x + 7, player.transform.position.x - 7), 6.2758f, player.transform.position.z + 7), Quaternion.identity);
	}
	void inst3()
	{
		if(player != null)
		enem_3=(GameObject)	Instantiate (enemies_3, new Vector3 (Random.Range (player.transform.position.x + 7, player.transform.position.x - 7), 6.2758f, player.transform.position.z + 7), Quaternion.identity);
	}
	void inst_rand()
	{
		if (rand() == 1)
		{
			if(player != null)
			enem_rand=(GameObject)	Instantiate (enemies_2, new Vector3 (Random.Range (player.transform.position.x + 2, player.transform.position.x - 2), 6.2758f, player.transform.position.z + 7), Quaternion.identity);
		}
		if (rand() == 2)
		{
			if(player != null)
			enem_rand=(GameObject)	Instantiate (enemies_3, new Vector3 (Random.Range (player.transform.position.x + 2, player.transform.position.x - 2), 6.2758f, player.transform.position.z + 7), Quaternion.identity);
		}

	}
	int rand()
	{
		a = Random.Range (1,2);
		return a;
	}
	// Update is called once per frame
	void FixedUpdate () 
	{

	
		rand ();
		Destroy (enem_1,4.0f);
		Destroy (enem_2,4.0f);
		Destroy (enem_3,4.0f);
		Destroy (enem_rand,4.0f);
						
	}
}