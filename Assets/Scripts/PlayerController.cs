using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float force = 400f;

	private Rigidbody2D rb2d;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		float x = Input.GetAxis ("Horizontal");

		#if UNITY_IOS || UNITY_ANDROID
			x = Input.acceleration.x;
		#endif

		if (x < 0) {
			transform.rotation = new Quaternion (0, 0, 0, 0);
		} else if (x > 0) {
			transform.rotation = new Quaternion (0, 180, 0, 0);
		}

		rb2d.AddForce (new Vector2 (force * x, 0), ForceMode2D.Force);
	}
}
