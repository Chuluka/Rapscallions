using UnityEngine;
using System.Collections;

public class RoofLight : MonoBehaviour {

	//Initialise Variables
	public bool powerOn = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (powerOn == true)
		{
			GetComponent<Light>().intensity = 8;
		}

		if (powerOn == false)
		{
			GetComponent<Light>().intensity = 0;
		}
	}

	public void SwitchOn ()
	{
		powerOn = true;
	}

	public void SwitchOff ()
	{
		powerOn = false;
	}
}
