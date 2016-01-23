using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CreditsScript : MonoBehaviour
{
	public int buttonWidth = 128;
	public int buttonHeight = 32;

	void OnGUI ()
	{
		Rect backButton = new Rect (10, 10, buttonWidth, buttonHeight);

		if (GUI.Button (backButton, "Back")) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
