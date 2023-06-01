using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int point = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            AddPoint();
            Destroy(collision.gameObject);
        }
    }

    private void AddPoint()
    {
        point++;
    }
}
