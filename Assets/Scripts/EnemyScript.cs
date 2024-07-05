using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed=3;
    [SerializeField] private Rigidbody2D _rigitbody;
    [SerializeField] private bool _lookRight;
    public UnityEvent Dead;

    private void Update()
    {
        if (_lookRight)
            _rigitbody.velocity = new Vector2(_moveSpeed, _rigitbody.velocity.y);
        else
            _rigitbody.velocity = new Vector2(_moveSpeed*(-1), _rigitbody.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>();
        var bullet = collision.GetComponent<BulletScript>();

        if (bullet != null)
        {
            Dead?.Invoke();
            Destroy(gameObject);
        }

        if (player != null)
        {
            player.Dead?.Invoke();
            player._rigitbody.velocity = new Vector2(0, 0);
        }
    }

    /// <summary>
    /// //////////
    /// </summary>
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
