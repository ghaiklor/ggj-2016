using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CreditsScripts : MonoBehaviour
{
	public int buttonWidth = 128;
	public int buttonHeigth = 32;

	void OnGUI ()
	{
		Rect backButton = new Rect (5, 5, buttonWidth, buttonHeigth);

		if (GUI.Button (backButton, "Back")) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
