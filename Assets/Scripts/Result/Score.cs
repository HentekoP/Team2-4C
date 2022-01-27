using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = game.getscore();

        ScoreText.text = string.Format("0", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
