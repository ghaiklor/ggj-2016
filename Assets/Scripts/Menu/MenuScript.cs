using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour
{
	public int buttonWidth = 128;
	public int buttonHeight = 32;

	void OnGUI ()
	{
		Rect startGameRect = new Rect (Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight);
		Rect creditsRect = new Rect (Screen.width / 2 - buttonWidth / 2, Screen.height / 2 + buttonHeight, buttonWidth, buttonHeight);

		if (GUI.Button (startGameRect, "Start Game")) {
			SceneManager.LoadScene ("Game");
		} else if (GUI.Button (creditsRect, "Credits")) {
			SceneManager.LoadScene ("Credits");
		}
	}
}
