using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {
	public GameObject shell;
	public Transform raycast_empty;
	public GameObject zombie_;
	public Renderer muzal_flash;
	public Light flash_light;
	public GameObject muzzal_flash;
	private GameObject clone_;
	public GameObject bullet_hole;
	public GameObject target;
	public static bool fall;


	// Use this for initialization
	void Start () {
		//Screen.showCursor = false;
		muzal_flash.enabled = false;
		flash_light.enabled = false;
	}

	IEnumerator flash()
	{
		//Debug.Log ("hit");
		muzzal_flash.transform.Rotate (0,0,40);
		muzal_flash.renderer.enabled = true;
		flash_light.enabled = true;
		yield return new WaitForSeconds (0.02f);
		muzal_flash.renderer.enabled = false;
		flash_light.enabled = false;
	}

	void main_fun()
	{
		///if(Input.GetButtonDown("Fire1"))
		if(Input.GetMouseButtonDown(0))
		{
			StartCoroutine ("flash");
			
			clone_ =(GameObject)Instantiate(shell,target.transform.position,Quaternion.identity);
			audio.Play();
			RaycastHit hit;
			Ray my_ray=new Ray (raycast_empty.transform.position,raycast_empty.transform.forward);
			if(Physics.Raycast(my_ray,out hit,1000))
			{
				
				if(hit.collider.tag=="enemy")
				{    
					Debug.Log("hit");
					fall=true;
					///Destroy(hit.collider.gameObject);
				}

			}
		}
		Destroy (clone_,0.7f);
		if(Vector3.Distance(transform.position,shell.transform.position) > 500)
		{
			
		}
	}
	// Update is called once per frame
	void FixedUpdate () {

		main_fun ();
	}


}
