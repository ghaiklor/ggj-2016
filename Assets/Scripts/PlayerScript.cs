using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	private Light light;

	void Start ()
	{
		light = GetComponentInChildren<Light> ();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Ghost") {
			light.range = light.range * 0.5f;

			if (light.intensity <= 1f || light.range <= 1f) {
				light.range = 20f;
			}
		}
	}
}
