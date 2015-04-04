using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {
	public GameObject shell;
	public GameObject bullet_empty;
	public GameObject zombie_;
	public Renderer muzal_flash;
	public Light flash_light;
	public GameObject muzzal_flash;
	private GameObject clone_;
	private GameObject bullet_clone;
	public GameObject target;
	public static bool fall1;
	public static bool fall2;
	public static int zomb_kill_count;
	//public GameObject bullet;


	// Use this for initialization
	void Start () {
		//Screen.showCursor = false;
		muzal_flash.enabled = false;
		flash_light.enabled = false;
		zomb_kill_count = 0;
	}

	IEnumerator flash()
	{
		muzzal_flash.transform.Rotate (0,0,40);
		muzal_flash.renderer.enabled = true;
		flash_light.enabled = true;
		yield return new WaitForSeconds (0.02f);
		muzal_flash.renderer.enabled = false;
		flash_light.enabled = false;
	}

	void main_fun()
	{
		if(Input.GetButtonUp("Fire1"))
		///if(Input.GetMouseButtonDown(0))
		{
			var direction = transform.TransformDirection(Vector3.forward);

			StartCoroutine ("flash");
			
			clone_ =(GameObject)Instantiate(shell,target.transform.position,Quaternion.identity);
			audio.Play();

			//bullet_clone =(GameObject)Instantiate(bullet,bullet_empty.transform.position,bullet_empty.transform.rotation);
			RaycastHit hit;
			Ray my_ray=new Ray (bullet_empty.transform.position , direction);
			if(Physics.Raycast(my_ray,out hit,8))
			{
				
				if(hit.collider.tag=="enemy")
				{    
					Debug.Log("hit");
					//fall1=true;
					zomb_kill_count++;
					Destroy(hit.collider.gameObject);
				}
			///	else{fall1=false;}
				if(hit.collider.tag=="enemy2")
				{    
					Debug.Log("hit");
					//fall2=true;
					zomb_kill_count++;
					Destroy(hit.collider.gameObject);
				}

			}
		}
		Destroy (clone_,0.4f);
		Destroy (bullet_clone,0.2f);
	}
	// Update is called once per frame
	void Update () {

		main_fun ();
	}


}
