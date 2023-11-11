using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

    private int oldHighScore;

    private void Start()
    {
    }

    private void Update()
    {
        this.StoreHighscore(Score.score);
        GetComponent<Text>().text = ("High Score\t: ") + this.oldHighScore;
    }

    private void StoreHighscore(int newHighscore)
    {
        this.oldHighScore = PlayerPrefs.GetInt("highscore", 0);
        if (newHighscore > this.oldHighScore)
        {
            PlayerPrefs.SetInt("highscore", newHighscore);
        }
    }
}
