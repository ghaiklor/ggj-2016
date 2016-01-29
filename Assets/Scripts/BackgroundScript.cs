using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour
{
	public Vector2 speed = new Vector2 (0, 0);
	public Vector2 direction = new Vector2 (0, 0);
	void Start (){
	}

	void Update ()
	{
		float bound = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
		if (transform.position.y  >= bound) {
			transform.position = new Vector3 (0, -bound,0);
		}
		transform.Translate (new Vector3 (speed.x * direction.x, speed.y * direction.y));
	}
}
