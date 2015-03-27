using UnityEngine;
using System.Collections;

public class fog : MonoBehaviour {

	public GameObject player;
	public ParticleSystem fogy1;
	public ParticleSystem fogy2;
	// Use this for initialization
	void Start () {
		//InvokeRepeating ("pos_change_fog1" ,1 ,3);
		//InvokeRepeating ("pos_change_fog2" ,1 ,5);
	}
	void pos_change_fog1()
	{
		if(player != null)
		fogy1.transform.position = player.transform.position + new Vector3(0,0,8);
	}

	void pos_change_fog2()
	{
		if(player != null)
		fogy2.transform.position = player.transform.position + new Vector3(0,0,12);
	}
	// Update is called once per frame
	void FixedUpdate () {
	

	}
}
