using UnityEngine;
using System.Collections;

public class GuardAI : MonoBehaviour {

	public float speed = 0f;
	public Transform[] Waypoints;
	public int currentWayPoint;
	public bool doPatrol = true;
	public Vector3 Target;
	public Vector3 MoveDirection;
	public Vector3 Velocity;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (currentWayPoint < Waypoints.Length) {
			Target = Waypoints [currentWayPoint].position;
			MoveDirection = Target - transform.position;
			Velocity = GetComponent<Rigidbody>().velocity;

			if (MoveDirection.magnitude < 1) {
				currentWayPoint++;
			} else {
				Velocity = MoveDirection.normalized * speed;
			}
		}
		else
			{
				if(doPatrol == true)
				{
					currentWayPoint = 0;
				}
				else{
					Velocity = Vector3.zero;
				}
			}

		GetComponent<Rigidbody>().velocity = Velocity;
			transform.LookAt(Target);
		}

	}

