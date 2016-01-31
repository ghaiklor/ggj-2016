using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour
{
	private GameObject player;
	private float speed = 1f;

	void Start ()
	{
		float randomScale = Random.Range (0.2f, 0.4f);

		player = GameObject.FindWithTag ("Player");
		speed = (float)Random.Range (8f, 12f);
		transform.localScale = new Vector3 (randomScale, randomScale, 0);
	}

	void Update ()
	{
		float x = player.transform.position.x < transform.position.x ? -0.05f : 0.05f;
		float y = speed * Time.deltaTime;

		transform.Translate (x, y, 0);
	}

	void OnBecameInvisible ()
	{
		Destroy (gameObject);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Destroy (gameObject);
	}
}
