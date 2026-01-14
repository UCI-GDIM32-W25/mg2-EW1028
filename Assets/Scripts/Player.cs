using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody2D _rigidbody;
    
    private bool _isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = false;
        }
    }
   

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.Space ) && _isGrounded)
        {
            Debug.Log("Jump");
            _isGrounded = false;
            
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump);
        }
    }
}
