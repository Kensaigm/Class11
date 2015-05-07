using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private int _score;
	public Text ScoreText;


	public void IncrementScore(int count)
	{
		_score += count;

		Debug.Log ("Score is now :" + _score);
		ScoreText.text = "Score: " + _score;
	}




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
