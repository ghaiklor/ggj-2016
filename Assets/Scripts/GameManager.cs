using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public Text GameOverText;
	public AudioSource BackgroundAudio;
	public GameObject ghost;

	private Coroutine ghostCoroutine;

	void Start ()
	{
		ghostCoroutine = StartCoroutine (SpawnRandomGhost ());
	}

	public IEnumerator GameOver ()
	{
		StopCoroutine (ghostCoroutine);
		BackgroundAudio.enabled = false;
		GameOverText.enabled = true;

		GameObject[] ghosts = GameObject.FindGameObjectsWithTag ("Ghost");
		foreach (GameObject ghost in ghosts) {
			Destroy (ghost);
		}

		yield return new WaitForSeconds (7f);
		Application.Quit ();
	}

	public IEnumerator SpawnRandomGhost ()
	{
		while (true) {
			GameObject toInstantiate = ghost;
			Vector3 position = new Vector3 (Random.Range (-6f, 6f), -6f, -1f);
			Instantiate (toInstantiate, position, Quaternion.identity);
			
			yield return new WaitForSeconds ((int)Random.Range (1, 3));
		}
	}
}
