using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
	public Vector2 speed = new Vector2 (0f, 0.1f);
	public Vector2 direction = new Vector2 (0f, 1f);

	void Update ()
	{
		transform.Translate (new Vector3 (speed.x * direction.x, speed.y * direction.y, 0));
	}
}
