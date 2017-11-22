using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    [SerializeField]
    public int health;
    public bool damaged;
    public int shieldDelay;

	// Use this for initialization
	void Start ()
    {
        damaged = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckPlayerHealth();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Zombie")
        {
            if (!damaged)
            {
                damaged = true;
                StartCoroutine(shield());
            }
        }
    }

    void CheckPlayerHealth()
    {
        if (health == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    IEnumerator shield()
    {
        health--;
        yield return new WaitForSeconds(shieldDelay);
        damaged = false;
    }
}
