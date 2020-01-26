using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan_speed : MonoBehaviour
{
	public  Animator fan_move;
	float movespeed;
	float timer;
	float crnt_spd;

	bool speed_up_hold;

    // Start is called before the first frame update
    void Start()
    {
		movespeed = 2;
		 timer = 0f;
		//fan_move = GetComponent<Animator>();

		speed_up_hold = false;
	}

    // Update is called once per frame
    void Update()
    {	
		//timer += Time.deltaTime;
		crnt_spd = fan_move.GetFloat("fan_speed");
		Debug.Log(crnt_spd);

		if (Input.GetKeyDown(KeyCode.Z))
		{		
			Inc_Spd();
		}

		Btn_press();
    }

	public void Inc_Spd()
	{

		//movespeed += timer;
		movespeed += 1.2f * Time.deltaTime ;
		fan_move.SetFloat("fan_speed", movespeed);
		fan_move.Play("fan_move");
	
	}

	public void Speed_up_true()
	{
	
		speed_up_hold = true;
	}

	public void Speed_up_false()
	{
		speed_up_hold = false;
	}

	public void Btn_press()
	{
		if (speed_up_hold)
		{
			Inc_Spd();
		}
	}

}
