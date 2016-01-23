using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	private Vector2 currentDirection = Vector2.zero;

	void Move ()
	{
		transform.Translate (currentDirection);
	}

	void Start ()
	{
		InvokeRepeating ("Move", 0.5f, 0.5f);
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			currentDirection = Vector2.right;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			currentDirection = -Vector2.right;
		} else {
			currentDirection = Vector2.zero;
		}
	}
}
