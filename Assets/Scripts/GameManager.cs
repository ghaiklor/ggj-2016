using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public Text GUITotalTimeText;
	public GameObject background;
	public GameObject player;
	public GameObject ghost;

	private bool gameStarted = false;
	private float totalTime = 0f;

	void Start ()
	{
		gameStarted = true;

		SpawnPlayer ();
		SpawnBackground ();
		StartCoroutine (SpawnRandomGhost ());
	}

	void Update ()
	{
		if (gameStarted) {
			totalTime += Time.deltaTime;
			GUITotalTimeText.text = "Time: " + totalTime.ToString ("F1") + "s";
		}
	}

	public void GameOver ()
	{
		gameStarted = false;

		StopCoroutine ("SpawnRangomGhost");
		SceneManager.LoadScene ("Menu");
	}

	public void SpawnPlayer ()
	{
		Instantiate (player, new Vector3 (0f, 1f, 0), Quaternion.identity);
	}

	public void SpawnBackground ()
	{
		float height = background.GetComponent<SpriteRenderer> ().bounds.size.y;
		Instantiate (background, new Vector3 (0, height, 0), Quaternion.identity);
		Instantiate (background, new Vector3 (0, 0, 0), Quaternion.identity);
		Instantiate (background, new Vector3 (0, -height, 0), Quaternion.identity);
	}

	public IEnumerator SpawnRandomGhost ()
	{
		while (gameStarted) {
			GameObject toInstantiate = ghost;
			Vector3 position = new Vector3 (Random.Range (-6f, 6f), -6f, -1f);
			Instantiate (toInstantiate, position, Quaternion.identity);

			yield return new WaitForSeconds ((int)Random.Range (2, 5));
		}
	}
}
