using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OblakoScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigitbody;
    private GameObject _target; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>();

        if (player != null) // && collision.transform.position.y - collision.bounds.size.y / 2 > transform.position.y && collision.attachedRigidbody.velocity.y <= 0
        {
            var angle = _rigitbody.transform.localEulerAngles.z*(-1);
            //angle = Mathf.Repeat(angle + 180, 360) - 180;
            player.Jump((float)angle); //
        }
    }

    public void Update()
    {
        _target = GameObject.FindWithTag("Finish");
        if (_target.transform.position.y > transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
    