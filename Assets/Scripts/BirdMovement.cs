using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    private Vector2 direction = Vector2.down;
    private float _speed;

    public new Rigidbody2D rigidbody { get; private set; }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

   
    private void FixedUpdate()
    {
       // BirdSpawner.Speed();
        this.rigidbody.AddForce(this.direction * this._speed);
    }
}
