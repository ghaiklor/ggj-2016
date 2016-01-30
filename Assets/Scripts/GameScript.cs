using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameScript : MonoBehaviour
{
	public string TextToWin = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

	private string TypedText = "";

	void Update ()
	{
//		TextObject.transform.Translate (-Time.deltaTime * ScrollSpeed, 0, 0);
		if (TypedText.Length <= TextToWin.Length) {
			if (TypedText.Length > 0) {
				if (!TypedText [TypedText.Length - 1].Equals (TextToWin [TypedText.Length - 1])) {
//					TypedText = TypedText.Substring (0, TypedText.Length - 1);
					Debug.Log ("FAIL");
				}
			}
		} else {
			TypedText = TypedText.Substring (0, TypedText.Length - 1);
		}
	}
}
