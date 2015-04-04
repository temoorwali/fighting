using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class health_score : MonoBehaviour {
	public Text display_health;
	public static int health;
	private int health_to_kill;
	public static float distance;
	public Text display_meter;
	public Text dis_zomb_kill;
	public GameObject player;
	//public int zombie_counter;
	//public GameObject zombie1;
	//public GameObject zombie2;
	// Use this for initialization
	void Start () {
	
		health = 10;
		distance = 0.0f;
		///health_to_kill = 7;
	}

	void health_value()
	{
		display_health.text = health.ToString() + "%";
		if (health <= 0)
		{
			display_health.text = "Dead";

		}
	}
	void meter_distance()
	{
		if (player != null) 
		        {
						distance = distance + Time.deltaTime;
			/*if(zomb_anim.meters_inc_by_10 == true)
			{
				distance=distance+10*Time.deltaTime;
				zomb_anim.meters_inc_by_10=false;
			}*/
						display_meter.text = distance.ToString ();
				}
	}
	void zombie_killed_counter()
	{
		dis_zomb_kill.text = fire.zomb_kill_count.ToString ();


	}
	// Update is called once per frame
	void FixedUpdate () 
	{
		health_value ();
		meter_distance ();
		zombie_killed_counter ();
	}
}
