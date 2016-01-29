using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	public GameObject player;
	public List<GameObject> candles;
	public List<GameObject> ghosts;
	public GameObject bkg;

	private bool gameStarted = false;

	void Start ()
	{
		gameStarted = true;

		SpawnPlayer ();
		StartCoroutine (SpawnRandomCandle ());
		StartCoroutine (SpawnRandomGhost ());

		float height = bkg.GetComponent<SpriteRenderer> ().bounds.size.y;
		Instantiate (bkg, new Vector3 (0, - (height / 4.0f)), new Quaternion ());
		Instantiate (bkg, new Vector3 (0, - height - (height / 4.0f)), new Quaternion ());
	}

	public void SpawnPlayer ()
	{
		Instantiate (player, new Vector3 (2f, 2f, 0), Quaternion.identity);
	}

	public IEnumerator SpawnRandomCandle ()
	{
		while (gameStarted) {
			GameObject toInstantiate = candles [Random.Range (0, candles.Count)];
			Vector3 position = new Vector3 (Random.Range (-5f, 5f), -10f, 0);
			Instantiate (toInstantiate, position, Quaternion.identity);

			yield return new WaitForSeconds ((int)Random.Range (0, 20));
		}
	}

	public IEnumerator SpawnRandomGhost ()
	{
		while (gameStarted) {
			GameObject toInstantiate = ghosts [Random.Range (0, ghosts.Count)];
			Vector3 position = new Vector3 (Random.Range (-5f, 5f), -10f, 0);
			Instantiate (toInstantiate, position, Quaternion.identity);

			yield return new WaitForSeconds ((int)Random.Range (0, 20));
		}
	}
}
