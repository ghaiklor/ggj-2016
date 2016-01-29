using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed = 10f;

	private Rigidbody2D rb2d;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		float x = Input.GetAxis ("Horizontal");

		rb2d.AddForce (new Vector2 (speed * x * Time.deltaTime, 0), ForceMode2D.Force);
	}
}
