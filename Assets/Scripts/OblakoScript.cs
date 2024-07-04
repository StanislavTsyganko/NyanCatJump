using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OblakoScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigitbody;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>();

        if (player != null && collision.attachedRigidbody.velocity.y < 0) // && collision.transform.position.y - collision.bounds.size.y / 2 > transform.position.y
        {
            var angle = _rigitbody.transform.localEulerAngles.z*(-1);
            //angle = Mathf.Repeat(angle + 180, 360) - 180;
            player.Jump((float)angle); //
        }
    }
}
    