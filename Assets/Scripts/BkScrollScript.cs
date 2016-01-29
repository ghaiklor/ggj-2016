using UnityEngine;
using System.Collections;

public class BkScrollScript : MonoBehaviour
{
	public Vector2 speed = new Vector2 (0, 0);
	public Vector2 direction = new Vector2 (0, 0);

	void Update ()
	{
		transform.Translate (new Vector3 (speed.x * direction.x, speed.y * direction.y, 0));
	}
}
