using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class health_score : MonoBehaviour {
	public Text display_health;
	public static int health;
	private int health_to_kill;
	private float distance;
	public Text display_meter;
	// Use this for initialization
	void Start () {
		health = 20;
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
		distance = distance + Time.deltaTime;
		//int t = (int) (distance * 10.0f);
		display_meter.text = distance.ToString ();
	}
	// Update is called once per frame
	void FixedUpdate () 
	{
		health_value ();
		meter_distance ();
	}
}
