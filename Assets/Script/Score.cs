using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public static int score;
	private int j;
	
	private void Start()
	{
        Invoke("TambahScore", 0.5f);
        Score.score = 0;
		j = 0;
	}
	
	private void Update()
	{
		GetComponent<Text>().text = string.Empty + (Score.score);
        GameOverScore.game_over_score = score;
    }

    private void TambahScore()
    {
        Score.score += 1;
        base.Invoke("TambahScore", 0.5f);
    }
}
