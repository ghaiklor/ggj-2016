using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour
{
	public float speed = 10f;

	void Update ()
	{
		transform.Translate (0, speed * Time.deltaTime, 0);
	}
}
