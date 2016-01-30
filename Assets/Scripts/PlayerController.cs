using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float force = 1000f;

	private Rigidbody2D rb2d;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		float x = Input.GetAxis ("Horizontal");

		rb2d.AddForce (new Vector2 (force * x, 0), ForceMode2D.Force);
	}
}
