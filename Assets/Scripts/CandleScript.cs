using UnityEngine;
using System.Collections;

public class CandleScript : MonoBehaviour
{
	public float speed = 1f;

	void Update ()
	{
		transform.Translate (0, speed * Time.deltaTime, 0);
	}

	void OnBecameInvisible ()
	{
		Destroy (gameObject);
	}
}
