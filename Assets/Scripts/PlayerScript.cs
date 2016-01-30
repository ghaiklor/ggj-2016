using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	private Light light;
	private GameManager gameManager;

	void Start ()
	{
		light = GetComponentInChildren<Light> ();
		gameManager = GameObject.FindGameObjectWithTag ("Scripts").GetComponent<GameManager> ();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Ghost") {
			light.range = light.range * 0.5f;

			if (light.intensity <= 1f || light.range <= 2f) {
				gameManager.GameOver ();
			}
		}
	}
}
