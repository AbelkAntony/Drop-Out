using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{

    public Vector2 direction { get; private set ; }

    public new Rigidbody2D rigidbody { get; private set; }
    public float speed = 30f;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && this.transform.position.x > -2f)
        {
            this.direction = Vector2.left;
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && this.transform.position.x < 2f)
        {
            this.direction = Vector2.right;
        }
        else
        {
            this.direction = Vector2.zero;
        }

    }

    private void FixedUpdate()
    {
        if (this.direction != Vector2.zero)
        {
            this.rigidbody.AddForce(this.direction * this.speed);
        }
    }

   
}
