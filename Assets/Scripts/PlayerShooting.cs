using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerShooting : MonoBehaviour {

    [SerializeField]
    private int rotateSpeed;
    private GameObject shootStick;
    [SerializeField]
    private GameObject bullet;
    private Rigidbody myBody;
    private float heading;
    public Transform muzzle;
    public float shootDelay;


    void Start () {
        shootStick = GameObject.FindGameObjectWithTag("ShootStick");
	}
    
    void FixedUpdate()
    {
        //this.transform.Rotate(0, CrossPlatformInputManager.GetAxis("RightHorizontal") * rotateSpeed, 0); // turn left and right
        if (shootStick.GetComponent<ShootStick>().shooting)
        {
            heading = Mathf.Atan2(shootStick.GetComponent<ShootStick>().delta.x, shootStick.GetComponent<ShootStick>().delta.y);
            transform.rotation = Quaternion.Euler(0f, -heading * Mathf.Rad2Deg, 0f); // Lets the player turn the way the joystick is facing
        }
    }

    public void ShootDelay(bool shoot)
    {
        if (shoot)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        Instantiate(bullet, new Vector3(muzzle.position.x, muzzle.position.y, muzzle.position.z), transform.rotation);
        yield return new WaitForSeconds(shootDelay);
        ShootDelay(shootStick.GetComponent<ShootStick>().shooting);
    }
}
