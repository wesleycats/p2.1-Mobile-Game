using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour 
{


	void Start()
	{

	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bullet") 
		{
			Destroy (gameObject);
		}
	}

}
