using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    [SerializeField] GameObject bird;
    private float time = 0;
    private Vector3 randomPosition;
    
    public float spawnDuration;

    private void Update()
    {
        if(Time.time > this.time)
        {
            this.time = this.time + this.spawnDuration;
            float x = Random.Range(-2.3f, 2.3f);
            float y = this.transform.position.y;
            randomPosition = new (x, y, 0);
            Instantiate(bird, randomPosition , transform.rotation);
        }
    }
}