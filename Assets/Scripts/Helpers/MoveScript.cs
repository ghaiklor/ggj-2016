using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
	public Vector2 speed = new Vector2 (50, 50);
	public Vector2 direction = new Vector2 (0, 1);

	void FixedUpdate ()
	{
		transform.Translate (new Vector2 (speed.x * direction.x, speed.y * direction.y));
	}
}
