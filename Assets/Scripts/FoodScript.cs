using UnityEngine;
using System.Collections;

public class FoodScript : MonoBehaviour
{
	public GameObject foodPrefab;

	public Transform borderTop;
	public Transform borderRight;
	public Transform borderBottom;
	public Transform borderLeft;

	public void Spawn ()
	{
		int x = (int)Random.Range (borderLeft.position.x, borderRight.position.x);
		int y = (int)Random.Range (borderBottom.position.y, borderTop.position.y);

		Instantiate (foodPrefab, new Vector2 (x, y), Quaternion.identity);
	}

	void Start ()
	{
		InvokeRepeating ("Spawn", 3, 4);
	}
}
