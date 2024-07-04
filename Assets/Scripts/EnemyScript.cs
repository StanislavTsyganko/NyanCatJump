using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed=3;
    [SerializeField] private Rigidbody2D _rigitbody;
    [SerializeField] private bool _lookRight;

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

        if (player != null)
        {
            player.Dead?.Invoke();
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
