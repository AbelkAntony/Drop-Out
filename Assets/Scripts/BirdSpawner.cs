using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    [SerializeField] GameObject bird;
    public float time;

    public float position;
    private void Update()
    {
        if(Time.deltaTime <= time)
        {
            this.transform.position += Vector3.one * position;
            Instantiate(bird);
        }
    }
}
