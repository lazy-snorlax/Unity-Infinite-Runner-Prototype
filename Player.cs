using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _character;

    [SerializeField]
    private float _speed = 5.0f;
    [SerializeField]
    private float _jumpHieght = 10.0f;
    [SerializeField]
    private float _gravity = 1.0f;
    private float _yVelocity = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        _character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // direction to travel (vector3)
        Vector3 dir = new Vector3(0, 0, 1);
        // velocity = direction * speed
        Vector3 velocity = dir * _speed;

        // if canJump
        // velocity on the Y = jumpHeight
        if (_character.isGrounded == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _yVelocity = _jumpHieght;
            }
        }
        else
        {
            // add gravity
            _yVelocity -= _gravity;
        }

        velocity.y = _yVelocity;
        // move (veolocity * time)
        _character.Move(velocity * Time.deltaTime);
    }
}
