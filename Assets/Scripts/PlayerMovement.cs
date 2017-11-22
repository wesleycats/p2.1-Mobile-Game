using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private int moveSpeed;
    Rigidbody myBody;

	void Start ()
    {
        myBody = this.GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 1, 0);
	}

    void FixedUpdate()
    {
        Vector3 moveVec = new Vector3(CrossPlatformInputManager.GetAxis("LeftHorizontal"), 0, CrossPlatformInputManager.GetAxis("LeftVertical")) * moveSpeed;
        myBody.AddForce(moveVec);
    }
}
