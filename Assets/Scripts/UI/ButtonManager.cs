using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void Play()
    {
		SceneManager.LoadScene("Wesley");
	}
	public void MainMenu()
    {
		SceneManager.LoadScene("Main Menu");
	}
	public void Quit()
    {
		Application.Quit ();
	}
}
