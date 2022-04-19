using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxVelocity : MonoBehaviour
{
    Rigidbody2D body;
    public float maxVel;
    
    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(body.velocity.sqrMagnitude > maxVel)
        {
            body.velocity *= 0.9f;
        }
    }
}
