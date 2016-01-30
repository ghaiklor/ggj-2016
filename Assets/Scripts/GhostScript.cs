using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour
{
	void Start ()
	{
		Rigidbody2D rb2d = GetComponent<Rigidbody2D> ();
		rb2d.gravityScale = Random.Range (-0.5f, -0.1f);
	}

	void OnBecameInvisible ()
	{
		Destroy (gameObject);
	}
}
