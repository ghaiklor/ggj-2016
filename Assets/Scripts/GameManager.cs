using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	public GameObject player;
	public List<GameObject> ghosts;

	private bool gameStarted = false;

	void Start ()
	{
		gameStarted = true;

		SpawnPlayer ();
		StartCoroutine (SpawnRandomGhost ());
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
