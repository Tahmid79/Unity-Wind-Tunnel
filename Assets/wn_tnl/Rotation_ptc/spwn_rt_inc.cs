using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.Experimental.VFX;
using UnityEngine.UI;

public class spwn_rt_inc : MonoBehaviour
{
	VisualEffect vfx;
	 rt fan_rotation;
	public GameObject fan;
	float rot_spd;

	public Text turb_txt;
	public Text rot_txt;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	private void Awake()
	{
		vfx = GetComponent<VisualEffect>();
		fan_rotation = fan.GetComponent<rt>();
		rot_spd = fan_rotation.rotation_speed / 10f;
	}


	// Update is called once per frame
	void Update()
    {
		rot_spd = fan_rotation.rotation_speed / 10f;

		Debug.Log("Turbulence = " + vfx.GetFloat("Turbulence") );
		Debug.Log("Rotation Speed " + rot_spd);

		//Increase_Spawn_rt();
		Directly_Proportional();

		

		turb_txt.text = "Turbulence : " + Mathf.Round(vfx.GetFloat("Turbulence") );
		rot_txt.text = "Rotation Speed : " +    Mathf.Round(rot_spd);
	}

	public void Inc_Spawn_rt()
	{
		float rte;
		rte = vfx.GetFloat("Spawn_Rate");
		
		rte += 50f;
		vfx.SetFloat("Spawn_Rate", rte);
		
	}

	void Increase_Spawn_rt()
	{

		float rte;
		rte = vfx.GetFloat("Spawn_Rate");

		rte = rte + (rot_spd / 5) / 10;
		vfx.SetFloat("Spawn_Rate", rte);

	}

	public void Directly_Proportional()
	{
		float turb;
		turb = vfx.GetFloat("Turbulence");

		float x = rot_spd;   // rotation speed
		float y = turb;      // turbulence

		y = 0.2f * x;

		vfx.SetFloat("Turbulence", y);


	}

	

	

}
