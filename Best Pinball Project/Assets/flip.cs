using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    public KeyCode press_left;
    private float angle;
    public float speed;
    public bool pressed = false;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(press_left) == true)
        {
            pressed = true;            
        }
        if (Input.GetKey(press_left) == false)
        {
            pressed = false;            
        }

        if (pressed == true)
        {
            if (transform.rotation.z <= 0.3)
            {
                Debug.Log("transform: " + transform.rotation.z);
                angle += Time.deltaTime * speed;
                transform.rotation = Quaternion.Euler(0, 0, angle);
            }
        }
        if (pressed == false)
        {
            if (transform.rotation.z >= -0.3)
            {
                Debug.Log("transform: " + transform.rotation.z);
                angle -= Time.deltaTime * speed;
                transform.rotation = Quaternion.Euler(0, 0, angle);
            }
        }
        
        //angle += Time.deltaTime * speed;
        ////transform.rotation = Quaternion.Euler(0, 0, angle);
        //transform.rotation = Quaternion.Euler(0, 0, 90);
    }
}
