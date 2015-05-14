using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private int _score;
	[SerializeField]
	private GameObject GameOverPanel;
//	private GameObject GameOverText;
	public Text ScoreText;


	public void IncrementScore(int count)
	{
		_score += count;

		Debug.Log ("Score is now :" + _score);
		ScoreText.text = "Score: " + _score;
	}

	public void PlayerDied()
	{
//		StartCoroutine (CoShowOverText ());
		GameOverPanel.SetActive (true);
	}

//	IEnumerator CoShowOverText()
//	{
//		GameOverText.text = "";
//		GameOverText.gameObject.SetActive (true);

//		string gameOver = "GAME OVER";
//		for (int i =0; i < gameOver.Length; i++) {
//			GameOverText.text = gameOver.Substring(0, i + 1);
//			if(gameOver[i] == ' ') continue;
//			yield return new WaitForSeconds(.5f);
//		}
//	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
