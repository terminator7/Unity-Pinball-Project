using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plungerBall : MonoBehaviour
{
    //Initalizing Bodies
    public SpriteRenderer spriteRenderer;
    public Sprite closeChestSprite;
    public Sprite openChestSprite;
    private Rigidbody2D ball;
    private Renderer rend;
    public Collider2D lowerBound;
    public Collider2D leftBound;

    //Initalizing Manipulated Variables
    private int remainingBalls;
    private bool isPressed;
    
    //Initalizing Consts
    private const int MAX_BALLS = 3;
    private const float Y_DIRECTION_LAUNCH = 1200.0f;
    private const float X_DIRECTION_LAUNCH = 50.0f;
    private const float BALL_POS_THRESHOLD = 1.5f;
    private const float STARTING_X = -2.76f;
    private const float ENDING_Y = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        ball = this.GetComponent<Rigidbody2D>();
        rend = this.GetComponent<Renderer>();
        
        rend.enabled = false;
        isPressed = false;
        remainingBalls = MAX_BALLS;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) && !isPressed) {
            isPressed = true;
            rend.enabled = true;
            ball.AddForce(new Vector2(0, Y_DIRECTION_LAUNCH), ForceMode2D.Impulse);
            spriteRenderer.sprite = openChestSprite;

        }


        if(ball.position.x >= STARTING_X-BALL_POS_THRESHOLD && ball.position.x <= STARTING_X+BALL_POS_THRESHOLD && ball.position.y >= ENDING_Y ) {
            ball.AddForce(new Vector2(X_DIRECTION_LAUNCH, 0), ForceMode2D.Impulse);
            StartCoroutine(waiter());
        }

        //Resetting Ball,lowering remaining ball count and reset lower bound when it touches the bounds
        if(ball.IsTouching(lowerBound)) {
            
            remainingBalls -= 1;
            transform.position = new Vector2(STARTING_X, -4.04f);
            ball.velocity = new Vector2(0, 0);
            isPressed = false;
            rend.enabled = false;
            leftBound.transform.localScale = new Vector2(-2.389359f, 50.29399f);
            spriteRenderer.sprite = closeChestSprite;
        }

    }

    //Closes Plunger
    IEnumerator waiter() {
        yield return new WaitForSeconds(0.25f);
        leftBound.transform.localScale = new Vector2(-2.389359f, 60.0f);
        yield return new WaitForSeconds(0.25f);
    }
}
