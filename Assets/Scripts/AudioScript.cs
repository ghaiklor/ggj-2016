using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour
{
	private AudioSource background;

	void Start ()
	{
		background = GetComponentInChildren<AudioSource> ();
	}

	void Update ()
	{
		background.panStereo = background.panStereo + Random.Range (-0.2f, 0.2f);
		background.volume = Mathf.Min (1f, Mathf.Max (background.volume + Random.Range (-0.01f, 0.01f), 0f));
	}
}
