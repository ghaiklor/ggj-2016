using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SnakeScript : MonoBehaviour
{
	private Vector2 direction = Vector2.right;

	void Start ()
	{
		InvokeRepeating ("Move", 0.3f, 0.3f);
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			direction = Vector2.right;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			direction = -Vector2.up;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			direction = -Vector2.right;
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			direction = Vector2.up;
		}
	}

	private void Move ()
	{
		transform.Translate (direction);
	}
}
