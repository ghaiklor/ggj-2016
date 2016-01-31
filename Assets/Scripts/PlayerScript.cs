using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	private new Light light;
	private GameManager gameManager;

	private float currentLightIntensity = 6f;
	private float currentLightRange = 40f;
	private float velocity = 0.0f;

	void Start ()
	{
		light = GetComponentInChildren<Light> ();
		gameManager = GameObject.FindGameObjectWithTag ("Scripts").GetComponent<GameManager> ();
	}

	void Update ()
	{
		currentLightIntensity = Mathf.Max (Mathf.Min (6f, Random.Range (light.intensity - 1f, light.intensity + 1f)), 2f);
		light.intensity = currentLightIntensity;
		light.range = Mathf.SmoothDamp (light.range, currentLightRange, ref velocity, 0.3f);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Ghost") {
			currentLightRange = Mathf.Max (0.5f, light.range - Mathf.Min (light.range * 0.7f, 4f));

			if (light.range <= 1.5f) {
				StartCoroutine (gameManager.GameOver ());
			}
		}
	}
}
