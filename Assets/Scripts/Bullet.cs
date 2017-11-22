using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Rigidbody rigidBody;

    [SerializeField]
    private float bulletSpeed;
    private Quaternion startRotation;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();        
    }

    void Start()
    {
        startRotation = transform.rotation;
    }

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject != GameObject.FindGameObjectWithTag("Player"))
        {
            Destroy(gameObject);
            if (other.transform.tag == "Zombie")
            {
                Destroy(other.gameObject);
            }
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = startRotation;
        Vector3 velocity = transform.forward * Time.fixedDeltaTime * bulletSpeed;
        rigidBody.MovePosition(rigidBody.position + velocity);
        transform.up = velocity;
    }
}
