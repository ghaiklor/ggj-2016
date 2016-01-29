using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour
{
	private GameObject player;
	private Rigidbody2D rb2d;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update ()
	{
//		Vector3 position = Vector3.SmoothDamp (transform.position, player.transform.position, ref Vector3.zero, Time.deltaTime);

//		transform.Translate (position);
	}
}
