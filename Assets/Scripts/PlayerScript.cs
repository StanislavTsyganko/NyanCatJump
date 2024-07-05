using UnityEngine;
using System;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;
    public UnityEvent Dead;
    public UnityEvent JumpEvent;

    [Header("Components")]

    [SerializeField] public Rigidbody2D _rigitbody;

    [SerializeField] private bool _lookRight;

    private void Update()
    {
        CheckFlip();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;

        if (collisionObject.CompareTag("DownPart"))
        {
            _rigitbody.velocity = new Vector2(0, 0);
        }
    }

    public void Jump(float angle)
    {
        float angleInRadians = (float)(angle * (Math.PI/180));
        double sinus = Mathf.Sin(angleInRadians);
        double cosinus = Mathf.Cos(angleInRadians);
        _rigitbody.velocity = new Vector2((float)(_jumpForce * sinus), (float)(_jumpForce * cosinus));
        JumpEvent?.Invoke();
    }

    private void CheckFlip()
    {
        if (_rigitbody.velocity.x > 0 && !_lookRight)
        {
            Flip();
        }
        else if (_rigitbody.velocity.x < 0 && _lookRight)
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