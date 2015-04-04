using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class final_score : MonoBehaviour {

	public Text disp_final_distance;
	public Text disp_enemy_killed;
	public Text disp_total_score;
	// Use this for initialization
	float total_calculataion()
	{
		int a = fire.zomb_kill_count * 5;
		float b = health_score.distance + a;
		return b;

	}
	void Start ()
	{
		try
		{
		Screen.showCursor = true;
		//Screen.lockCursor = false;
		disp_final_distance.text ="Meters " + health_score.distance.ToString ();
		disp_enemy_killed.text ="Killed   " + fire.zomb_kill_count.ToString ();
		disp_total_score.text ="Score  " + total_calculataion ().ToString ();
		}
		catch(MissingComponentException e)
		{
			Debug.Log(e.Message);
		}
	}

	public void restart()
	{
		Application.LoadLevel ("scene1");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
