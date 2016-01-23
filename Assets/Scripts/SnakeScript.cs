using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SnakeScript : MonoBehaviour
{
	public GameObject tailPrefab;

	private Vector2 direction = Vector2.right;
	private List<Transform> tail = new List<Transform> ();
	private bool ate = false;

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
		Vector2 v = transform.position;

		transform.Translate (direction);

		if (ate) {
			GameObject g = (GameObject)Instantiate (tailPrefab, v, Quaternion.identity);
			tail.Insert (0, g.transform);
			ate = false;
		} else if (tail.Count > 0) {
			tail.Last ().position = v;
			tail.Insert (0, tail.Last ());
			tail.RemoveAt (tail.Count - 1);
		}
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.name.StartsWith ("Food")) {
			ate = true;
			Destroy (collider.gameObject);
		} else {
			
		}
	}
}
