using UnityEngine;
using System.Collections;

public class Emerge : MonoBehaviour
{
	public GameObject go;
	private int partCount = 0;
	public GameObject g;
	void Start ()
	{
		g = (GameObject)Instantiate (go,new Vector3 (0, 5, 0),new Quaternion ());
		Vector3 scale = new Vector3 (3, 3,0);
		g.transform.localScale = scale;
		InvokeRepeating ("SpawnDemon", 0.2f, 0.2f);
	}

	public void SpawnDemon ()
	{
		if (partCount < 25) {
			print (partCount/25f);
			g.GetComponent<SpriteRenderer> ().color = new Color(1,1,1,partCount/25f);
			partCount++;
		} else {
			print ("Game over");
		}
	}
}
