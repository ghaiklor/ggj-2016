using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour
{
	private float speed = 1f;

	void Start ()
	{
		speed = (float)Random.Range (2f, 5f);
	}

	void Update ()
	{
		transform.Translate (0, speed * Time.deltaTime, 0);
	}

	void OnBecameInvisible ()
	{
		Destroy (gameObject);
	}
}
