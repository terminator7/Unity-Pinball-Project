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
        score_text.text = current_score.ToString();
    }
}
