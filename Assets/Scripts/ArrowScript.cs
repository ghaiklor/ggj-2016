using UnityEngine;
using System.Collections;

public class ArrowScript : MonoBehaviour
{
	public KeyCode validKeyCode;

	void Update ()
	{
		if (Input.GetKeyDown (validKeyCode)) {
			Destroy (gameObject);
		}
	}
}
