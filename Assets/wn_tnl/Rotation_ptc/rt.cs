using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rt : MonoBehaviour
{
	public float rotation_speed;
	bool speed_up_hold;
	bool speed_down_hold;

	// Start is called before the first frame update
	void Start()
    {
		//rotation_speed = 50f;
		speed_up_hold = false;
		speed_down_hold = false;
		Btn_press();

	}

    // Update is called once per frame
    void Update()
    {
		transform.Rotate(0, rotation_speed * Time.deltaTime, 0);
		//Debug.Log(rotation_speed);
		Btn_press();
	}

	public void Inc_Spd()
	{
		rotation_speed += 3f;//* Time.deltaTime;
		if (rotation_speed >= 500)
		{
			rotation_speed = 500f;
		}
	}

	
	public void Speed_up_true()
	{
		speed_up_hold = true;
	}

	public void Speed_up_false()
	{
		speed_up_hold = false;
	}

	/// ///////////////////////////////////////////////////////////////////

	public void Dec_Spd()
	{
		rotation_speed -= 3f;//* Time.deltaTime;
		if (rotation_speed <= 50)
		{
			rotation_speed = 50f;
		}
	}

	public void Speed_down_true()
	{
		speed_down_hold = true;
	}

	public void Speed_down_false()
	{
		speed_down_hold = false;
	}


/// ////////////////////////////////////////////////////////////

	public void Btn_press()
	{
		if (speed_up_hold)
		{
			Inc_Spd();
		}

		if (speed_down_hold)
		{
			Dec_Spd();
		}

	}


}
