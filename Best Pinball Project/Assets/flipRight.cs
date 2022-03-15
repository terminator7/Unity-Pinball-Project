using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipRight : MonoBehaviour
{
    Rigidbody2D body;
    public float speed;
    public KeyCode press_right;

    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(press_right) == true)
        {
            body.AddTorque(speed, ForceMode2D.Force);
        }
    }
}