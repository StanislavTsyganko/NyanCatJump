using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;

    [Header("Components")]

    [SerializeField] private Rigidbody2D _rigitbody;

    [SerializeField] private bool _lookRight;

    private void Update()
    {
        CheckFlip();
        //Move();
    }

   /* private void Move()
    {
        //_rigitbody.velocity = new Vector2(Input.acceleration.x * _moveSpeed, _rigitbody.velocity.y);

    }*/

    public void Jump(float angle)
    {
        float angleInRadians = (float)(angle * (Math.PI/180));
        double sinus = Mathf.Sin(angleInRadians);
        double cosinus = Mathf.Cos(angleInRadians);
        _rigitbody.velocity = new Vector2((float)(_jumpForce * sinus), (float)(_jumpForce * cosinus));

    }

    private void CheckFlip()
    {
        if (Input.acceleration.x > 0 && !_lookRight)
        {
            Flip();
        }
        else if (Input.acceleration.x < 0 && _lookRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

        _lookRight = !_lookRight;
    }
}