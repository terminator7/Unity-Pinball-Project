using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int current_score;
    public int increment;
    public Text score_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        IncrementScore(increment);
    }

    void IncrementScore(int x)
    {
        current_score += x;
        if (current_score < 9999999)
        {
            score_text.text = current_score.ToString();
        }
        else
        {
            score_text.text = "9999999";
        }
    }
}
