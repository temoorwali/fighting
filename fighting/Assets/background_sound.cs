using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class background_sound : MonoBehaviour {
	public GameObject tree;	
	GameObject tree1;
	GameObject tree2;
	public GameObject cam_pos_emp;
	public Text text_display;

	// Use this for initialization
	void Start () 
	{
		//text_display.transform.position = new Vector3 (Screen.width/5 , Screen.height/6 , 0);
		audio.Play ();
		InvokeRepeating ("inst1" , 1 , 5);
		InvokeRepeating ("inst2" , 1 , 9);

	}
	void inst1 ()
	{
		tree1 =(GameObject)	Instantiate (tree, new Vector3 ( cam_pos_emp.transform.position.x - 7 , 6.2758f, cam_pos_emp.transform.position.z + 35), Quaternion.identity);
	}
	void inst2()
	{
		tree2 =(GameObject)	Instantiate (tree, new Vector3 ( cam_pos_emp.transform.position.x + 7 , 6.2758f, cam_pos_emp.transform.position.z + 35), Quaternion.identity);
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		Destroy (tree1,6.5f);
		Destroy (tree2,10.5f);
	}
}