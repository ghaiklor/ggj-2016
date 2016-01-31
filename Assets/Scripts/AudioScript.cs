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
		background.panStereo = background.panStereo + Random.Range (-0.3f, 0.3f);
	}
}
