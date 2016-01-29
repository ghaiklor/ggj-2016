using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour
{
	void Start ()
	{
		InvokeRepeating ("ReduceLight", 2.0f, 2.0f);
	}

	void ReduceLight ()
	{
		gameObject.GetComponent<Light> ().intensity = GetComponent<Light> ().intensity - 1;
	}
}
