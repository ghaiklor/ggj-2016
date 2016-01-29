using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	private int _score = 0;

	public int GetScore ()
	{
		return _score;
	}

	public void SetScore (int score)
	{
		_score = score;
	}
}
