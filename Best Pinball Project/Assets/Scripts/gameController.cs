using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameController : MonoBehaviour
{
    public Text scoreText;

    private int score = 0;
    void Update()
    {
        
    }

    public void addScore() {
        score++;
        scoreText.text = "Score: " + score;
    }
}
