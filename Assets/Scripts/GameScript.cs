using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameScript : MonoBehaviour
{
	public GameObject[] arrows;

	void Start ()
	{
		InvokeRepeating ("AddNewArrow", 0f, 2f);
	}

	void Update ()
	{
		
	}

	void AddNewArrow ()
	{
		GameObject arrow = GameObject.FindGameObjectWithTag ("Arrow");

		if (arrow == null) {
			GameObject toInstantiate = arrows [Random.Range (0, arrows.Length)];
			Vector3 position = new Vector3 (0f, -2f, 0f);
			Instantiate (toInstantiate, position, Quaternion.identity);
		}
	}
}
