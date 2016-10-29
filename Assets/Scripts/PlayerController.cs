using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Declaring Variables
	public float speed = 18.0f;
	private Rigidbody rig;

	// Use this for initialization
	void Start () 
	{
		rig = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//Move the player
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (hAxis, 0, vAxis) * speed * Time.deltaTime;

		rig.MovePosition (transform.position + movement);
	}
}
