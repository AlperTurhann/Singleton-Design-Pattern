using TMPro;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
	[Header("References")]
	[SerializeField] TextMeshProUGUI scoreTxt;
	
	const string SCORE_TEXT = "Score: ";
	const int POINT = 10;

	void Start() => scoreTxt.text = SCORE_TEXT + GameManager.Instance.GetScore();
	
	public void UpdateScore() 
	{
		GameManager.Instance.GainScore(POINT);
		scoreTxt.text = SCORE_TEXT + GameManager.Instance.GetScore();
	}
}