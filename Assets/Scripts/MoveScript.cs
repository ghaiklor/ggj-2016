using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	private float speed = 7f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float sign = Random.value > 0.5 ? -1f : 1f;
		transform.Translate (0, speed * Time.deltaTime, 0);
		transform.Rotate (0, 0, 3f * sign);

	}

	void OnBecameInvisible ()
	{
		Destroy (gameObject);
	}
}
