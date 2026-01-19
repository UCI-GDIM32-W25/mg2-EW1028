using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private float destoryX = -10f;
    void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (transform.position.x < destoryX)
        {
            Destroy(gameObject);
        }
    }
}
