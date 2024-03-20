using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance { get; private set; }

	public int GetScore() { return score; }
	public void SetScore(int score) => this.score = score;
	
	[SerializeField] int score = 0;
	
	void Awake() 
	{
		if (Instance != null && Instance != this) Destroy(gameObject);
		else
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}
	
	void Update() { if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit(); }
	
	public void GainScore(int score) => this.score += score;
}