using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    Rigidbody2D body;
    public KeyCode press_r;

    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(press_r) == true)
        {
            transform.position = new Vector3(-2, 3, 0);
            body.velocity = new Vector3(0, 0, 0);
        }
    }
}
