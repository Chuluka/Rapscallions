using UnityEngine;
using System.Collections;

public class PowerBox : MonoBehaviour {

	public bool powerOn = true;
	private bool canSwitch = true;
	private float timer = 1.0f;
	public RoofLight _RoofLight;
	GameObject [] PoweredObject;


	// Use this for initialization
	void Start () {
		//PoweredObject = GetComponent<PoweredObject>();
		//PoweredObject.SwitchOff ();
		}		
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0) 
		{
			canSwitch = true;
		}

		//Switch Lights On
		if (powerOn == true) {
			foreach (GameObject PO in PoweredObject)
				_RoofLight.SwitchOn ();
			}

		//Switch Lights Off
		//if (powerOn == false) {
			//foreach (GameObject PO in PoweredObject)
				//PO._RoofLight.SwitchOff ();
		}

	}


	//Switch power on and off
	void OnMouseDown()
	{
		//Click to switch the power on and off
		if(Input.GetMouseButtonDown(0))
		{

			if(powerOn == false && canSwitch == true)
			{
				powerOn = true;
				timer = 0.25f;
				canSwitch = false;
				Debug.Log ("Power switched on");
			}

			if (powerOn == true && canSwitch == true)
			{
				powerOn = false;
				timer = 0.25f;
				canSwitch = false;
				Debug.Log ("Power switched off");
			}

		}


	}
}



