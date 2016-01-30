using UnityEngine;
using System.Collections;

public class CandleScript : MonoBehaviour
{
	public float minRangeLight = 1f;
	public float maxRangeLight = 2f;
	public float stepRangeLight = 0.1f;

	public float minGravityScale = -0.5f;
	public float maxGravityScale = -0.1f;

	private Rigidbody2D rb2d;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.gravityScale = (float)Random.Range (minGravityScale, maxGravityScale);
	}

	void OnBecameInvisible ()
	{
		Destroy (gameObject);
	}
}
