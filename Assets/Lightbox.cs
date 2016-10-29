using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lightbox : MonoBehaviour {

	public List<RoofLight> myLights = new List<RoofLight>();
	public bool isOn = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && PlayerInRange()) //TODO: change space to Action
		{
			ToggleSwitch();
		}
	}

	void ToggleSwitch() {
		isOn = !isOn;
		foreach (RoofLight rl in myLights)
		{			
			if (!isOn)
			{
				rl.SwitchOn();
			}
			else
			{
				rl.SwitchOff();
			}
		}
	}

	bool PlayerInRange()
	{
		float range = 10.0f;
		Transform playerPos = GameObject.FindGameObjectWithTag("Player").transform;
		return (Vector3.Distance (this.transform.position, playerPos.position) < range);
	}
}
