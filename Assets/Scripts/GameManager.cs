using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Text GUITotalTimeText;
	public GameObject background;
	public GameObject player;
	public List<GameObject> ghosts;

	private bool gameStarted = false;
	private float totalTime = 0f;

	void Start ()
	{
		gameStarted = true;

		SpawnPlayer ();
		StartCoroutine (SpawnRandomGhost ());

		float height = background.GetComponent<SpriteRenderer> ().bounds.size.y;
		Instantiate (background, new Vector3 (0, -(height / 4.0f)), new Quaternion ());
		Instantiate (background, new Vector3 (0, -height - (height / 4.0f)), new Quaternion ());
	}

	void Update ()
	{
		if (gameStarted) {
			totalTime += Time.deltaTime;
			GUITotalTimeText.text = "Time: " + totalTime.ToString ("F1");
		}
	}

	public void SpawnPlayer ()
	{
		Instantiate (player, new Vector3 (2f, 2f, 0), Quaternion.identity);
	}

	public IEnumerator SpawnRandomGhost ()
	{
		while (gameStarted) {
			GameObject toInstantiate = ghosts [Random.Range (0, ghosts.Count)];
			Vector3 position = new Vector3 (Random.Range (-5f, 5f), -6f, 0);
			Instantiate (toInstantiate, position, Quaternion.identity);

			yield return new WaitForSeconds ((int)Random.Range (0, 10));
		}
	}
}
