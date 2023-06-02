using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBird : MonoBehaviour
{

    public GameManager gameManager;

    private void Awake()
    {
        this.gameManager = FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            gameManager.LifeUpdate();
            Destroy(collision.gameObject);
        }
    }
}
