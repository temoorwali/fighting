using UnityEngine;
using System.Collections;

public class enemy_script : MonoBehaviour {
	public GameObject enemies_1;
	public GameObject enemies_2;
	public GameObject cam_pos_emp;
	 GameObject enem_1;
     GameObject enem_2;
	 GameObject enem_3;
	int a;
	// Use this for initialization
	void Start () 
	{
						InvokeRepeating ("inst1", 1.0f, 1.0f);
						InvokeRepeating ("inst2", 1.0f, 3.0f);
						InvokeRepeating ("inst3", 1.0f, 2.5f);
	}

	void inst1()
	{
		enem_1=(GameObject)	Instantiate (enemies_1, new Vector3 (Random.Range (cam_pos_emp.transform.position.x + 7, cam_pos_emp.transform.position.x - 7), 6.2758f, cam_pos_emp.transform.position.z + 15), Quaternion.identity);
	}
	void inst2()
	{
		enem_2=(GameObject)	Instantiate (enemies_2, new Vector3 (Random.Range (cam_pos_emp.transform.position.x + 7, cam_pos_emp.transform.position.x - 7), 6.2758f, cam_pos_emp.transform.position.z + 15), Quaternion.identity);
	}
	void inst3()
	{
		if (rand() == 1)
		{
			enem_3=(GameObject)	Instantiate (enemies_1, new Vector3 (Random.Range (cam_pos_emp.transform.position.x + 2, cam_pos_emp.transform.position.x - 2), 6.2758f, cam_pos_emp.transform.position.z + 15), Quaternion.identity);
		}
		if (rand() == 2)
		{
			enem_3=(GameObject)	Instantiate (enemies_2, new Vector3 (Random.Range (cam_pos_emp.transform.position.x + 2, cam_pos_emp.transform.position.x - 2), 6.2758f, cam_pos_emp.transform.position.z + 15), Quaternion.identity);
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
		Destroy (enem_1,2.5f);
		Destroy (enem_2,2.5f);
		Destroy (enem_3,2.5f);
		//if (player_kill.stop_enemy_script == true) 
						
	}
}