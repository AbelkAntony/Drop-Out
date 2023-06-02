using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    [SerializeField] GameObject bird;
    private GameObject _bird;
    private float time = 0;
    private Vector3 randomPosition;
    public float speed = 1;
    public float spawnDuration;

    private Vector2 direction = Vector2.down;
    public new Rigidbody2D rigidbody;

    private void Start()
    {
        time = Time.time;
    }
    private void Update()
    {
        if(Time.time > this.time)
        {
            this.time = this.time + this.spawnDuration;
            float x = Random.Range(-2.3f, 2.3f);
            float y = this.transform.position.y;
            randomPosition = new (x, y, 0);
            _bird = Instantiate(bird, randomPosition , transform.rotation);
            rigidbody =  _bird.GetComponent<Rigidbody2D>();
            this.rigidbody.AddForce(this.direction * this.speed);
            speed += 20;
        }
    }

   
}
