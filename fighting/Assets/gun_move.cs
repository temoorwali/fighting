using UnityEngine;
using System.Collections;

public class gun_move : MonoBehaviour {
	public GameObject gun;
	// Use this for initialization
	void Start () {
	
	}
	IEnumerator gun_mov()
	{
		Debug.Log ("in");
		float a = 0.2f;
	gun.transform.position = new Vector3 (gun.transform.position.x,gun.transform.position.y,gun.transform.position.z - 0.01f);
		yield return new WaitForSeconds (0.02f);
		//transform.position.z =a;
		gun.transform.position = new Vector3 (gun.transform.position.x,gun.transform.position.y,gun.transform.position.z + 0.01f);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
						StartCoroutine ("gun_mov");
				}
	}
}
