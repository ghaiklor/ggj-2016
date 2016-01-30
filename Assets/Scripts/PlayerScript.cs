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

	void Update ()
	{
		light.intensity = Mathf.Max (Random.Range (light.intensity - 0.5f, light.intensity + 0.5f), 2f);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Ghost") {
			light.range = light.range * 0.7f;

			if (light.range <= 2f) {
				gameManager.GameOver ();
			}
		}
	}
}
