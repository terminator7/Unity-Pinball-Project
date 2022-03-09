using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumperCollisionController : MonoBehaviour
{

    public gameController gameController;

    
    public void OnCollisionEnter2D(Collision2D other)
    {
        gameController.addScore();
    }
    
}
