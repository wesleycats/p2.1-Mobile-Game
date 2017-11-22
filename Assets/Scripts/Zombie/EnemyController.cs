using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed;

	private Rigidbody myRB;
	private GameObject thePlayer;


	// Use this for initialization
	void Start () 
	{
		myRB = GetComponent<Rigidbody>();
		thePlayer = GameObject.FindGameObjectWithTag("Player");
	}

	void FixedUpdate()
	{
		myRB.velocity = (transform.forward * moveSpeed);

	}

	// Update is called once per frame
	void Update () {
		transform.LookAt(thePlayer.transform.position);
	}
}
