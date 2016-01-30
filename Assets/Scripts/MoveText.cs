using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveText : MonoBehaviour {
	private Vector2 textStartPosition, textEndPosition;
	private RectTransform rectTransform;
	public Text Text;
	private float duration;
	// Use this for initialization
	void Start () {
		rectTransform = Text.GetComponent<RectTransform>();
		textStartPosition = rectTransform.anchoredPosition;
		textEndPosition = new Vector2(Screen.width/2,Screen.height/2);
		duration = 40f;
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(ShowText());
	}

	IEnumerator ShowText() {
		Text.enabled = true;

		float elapsedTime = 0;

		while (elapsedTime < duration) {
			float t = elapsedTime / duration; //0 means the animation just started, 1 means it finished
			rectTransform.anchoredPosition = Vector2.Lerp(textStartPosition,textEndPosition,t);
			elapsedTime += Time.deltaTime;
			yield return null;
		}

		Text.enabled = false;
	}

}
