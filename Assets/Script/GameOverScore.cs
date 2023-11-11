using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScore : MonoBehaviour {

    public static int game_over_score;

    private void Start()
    {
        GetComponent<Text>().text = ("Score \t\t: ") + game_over_score;
    }

    private void Update()
    {
        
    }
}
