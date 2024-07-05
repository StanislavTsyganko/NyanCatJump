using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float timer = 1;
    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if(timer<=0)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyScript>();

        if (enemy != null)
        {
            Destroy(gameObject);
        }
    }
}
