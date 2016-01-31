using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	private new Light light;
	private GameManager gameManager;

	private float currentLightIntensity;

	void Start ()
	{
		light = GetComponentInChildren<Light> ();
		gameManager = GameObject.FindGameObjectWithTag ("Scripts").GetComponent<GameManager> ();
	}

	void Update ()
	{
		currentLightIntensity = Mathf.Max (Mathf.Min (6f, Random.Range (light.intensity - 1f, light.intensity + 1f)), 2f);
		light.intensity = currentLightIntensity;
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Ghost") {
			light.range = light.range * 0.7f;

			if (light.range <= 1f) {
				gameManager.GameOver ();
			}
		}
	}
}
