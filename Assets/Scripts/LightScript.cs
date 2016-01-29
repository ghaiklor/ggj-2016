using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("ReduceLight", 2.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void ReduceLight() {
		gameObject.GetComponent<Light> ().intensity = GetComponent<Light> ().intensity - 1;
	}
}
