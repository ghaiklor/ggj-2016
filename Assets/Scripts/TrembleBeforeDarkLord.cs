using UnityEngine;
using System.Collections;

public class TrembleBeforeDarkLord : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float [] sign = new float[3];
		float delta = 0.1f;
		for (int i = 0;i < 3;i++){
			sign[i] = Random.value > 0.5f ? -1f * delta : 1f * delta;
		}

		transform.Translate (Random.value * sign[0], Random.value * sign[1], 0);
	}
}
