using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour
{
	public Animation CutSceneAnimation;

	IEnumerator Start ()
	{
		yield return WaitForAnimation (CutSceneAnimation);
		SceneManager.LoadScene ("Game");
	}

	public IEnumerator WaitForAnimation (Animation animation)
	{
		do {
			yield return null;
		} while (animation.isPlaying);
	}
}
