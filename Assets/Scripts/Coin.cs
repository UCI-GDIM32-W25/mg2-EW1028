using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameController gameController = FindObjectOfType<GameController>();
            gameController.points += 1;
            gameController.UpdatePoints();
            Destroy(gameObject);
        }
    }
}
