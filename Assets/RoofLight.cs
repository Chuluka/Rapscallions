using UnityEngine;
using System.Collections;

public class RoofLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void SwitchOn ()
	{
		GetComponent<Light>().intensity = 8;
	}

	public void SwitchOff ()
	{
		GetComponent<Light>().intensity = 0;
	}
}
