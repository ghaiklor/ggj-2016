using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

	public GameObject player;
	GameObject go;

	public void Start ()
	{
		go = (GameObject)Instantiate (player, new Vector3 (0, 1.5f, 0), new Quaternion (0, 0, -170, 0));
		go.GetComponent<MoveScript> ().enabled = false;
	}

	public void OnClick (int len)
	{
		go.GetComponent<MoveScript> ().enabled = true;
		StartCoroutine (Example ());
	}

	IEnumerator Example ()
	{
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene ("Game");
	}
}
