using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	//Declare variables
	public bool closed = true;
	public float openspeed = 2.0f;
	public float opendistance = 1.0f;
	private float xorigin = 0.0f;
	private float yorigin = 0.0f;
	private float zorigin = 0.0f;
	public bool xdirection = true;
	public bool ydirection = false;
	public bool zdirection = false;
	public bool positivedirection = true;
	private float opendirection = 0;
	private float xposition = 0.0f;
	private float yposition = 0.0f;
	private float zposition = 0.0f;
	private float direction = 0.0f;
	private float timer = 0.0f;
	private bool canopen = true;
	private float xoriginrotation = 0.0f;
	private float yoriginrotation = 0.0f;
	private float zoriginrotation = 0.0f;
	private float xrotation = 0.0f;
	private float yrotation = 0.0f;
	private float zrotation = 0.0f;


	//Set variables at creation
	void Start()
	{
		//Find the door's original position
		xorigin = transform.position.x;
		yorigin = transform.position.y;
		zorigin = transform.position.z;
		xoriginrotation = transform.rotation.x;
		yoriginrotation = transform.rotation.y;
		zoriginrotation = transform.rotation.z;

		//Set Opening variables
		xposition = openspeed*opendirection;
		yposition = openspeed*opendirection;
		zposition = openspeed*opendirection;
	}

	// Update is called once per frame
	void Update ()
	{
		//Default to the x direction if more than one box is checked	
		if (xdirection == true && ydirection == true || xdirection == true && zdirection == true || ydirection == true && zdirection == true) {
			xdirection = true;
			ydirection = false;
			zdirection = false;
		}

		//Set the postive or negative direction on a given plane
		if (positivedirection == true) {
			direction = 1;
		}
		if (positivedirection == false) {
			direction = -1;
		}

		//Stay Closed if the door is closed
		if (closed == true) 
		{
			transform.position = new Vector3 (xorigin, yorigin, zorigin);
			transform.rotation = Quaternion.Euler(xoriginrotation, yoriginrotation, zoriginrotation); 
		}

		//Open the door and stop openning when the door is fully open
		if (xdirection == true) { //open in x plane
			xposition = xorigin + opendistance*direction;
			yposition = yorigin;
			zposition = zorigin + opendistance*direction;
			xrotation = xoriginrotation;
			yrotation = 90;
			zrotation = xoriginrotation;
		}

		if (ydirection == true) { //open in x plane
			xposition = xorigin;
			yposition = yorigin + opendistance*direction;
			zposition = zorigin + opendistance*direction;
			xrotation = xoriginrotation;
			yrotation = 90;
			zrotation = zoriginrotation;
		}

		if (zdirection == true) { //open in x plane
			xposition = xorigin + opendistance*direction; 
			yposition = yorigin;
			zposition = zorigin + opendistance*direction;
			xrotation = xoriginrotation;
			yrotation = 90;
			zrotation = zoriginrotation;
		}

		if (closed == false) 
		{
			transform.position = new Vector3 (xposition, yposition, zposition);
			transform.rotation = Quaternion.Euler(xrotation,yrotation,zrotation); 
		}

		//Time out between openning and closing the door
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			canopen = true;
		}


	}
	void OnMouseDown()
	{
		//Click to open or close the door
		if(Input.GetMouseButtonDown(0))
		{

			if(closed == false && canopen == true)
			{
				closed = true;
				timer = 0.25f;
				canopen = false;
				Debug.Log ("Door closed after mouse click");
			}

			if (closed == true && canopen == true)
			{
				closed = false;
				timer = 0.25f;
				canopen = false;
				Debug.Log ("Door opened after mouse click");
			}

		}


	}
}
	
