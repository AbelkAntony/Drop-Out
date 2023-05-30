using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    private Vector3 movement;
    public float speed;
    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            movement = Vector3.left;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            movement = Vector3.right;
        }
        else
        {
            movement = Vector3.zero;
        }
        
        
        this.transform.position += (movement * Time.deltaTime * speed);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}
