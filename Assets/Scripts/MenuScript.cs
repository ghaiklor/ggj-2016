using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour
{
	IEnumerator Start ()
	{
		yield return new WaitForSeconds (6f);
		SceneManager.LoadScene ("Game");
	}
}
