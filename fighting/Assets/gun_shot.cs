using UnityEngine;
using System.Collections;

public class gun_shot : MonoBehaviour {
	//public GameObject muzzal_flash;
	public Renderer flash_light;
	
	// Use this for initialization
	void Start () {
		flash_light.renderer.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
