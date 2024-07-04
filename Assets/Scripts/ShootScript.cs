using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    private List<GameObject> _enemys;
    private EnemyScript _closest;
    private GameObject bullet;
    private Transform _shotPoint;/*
    [SerializeField] private Area area;*/

   /* void Update()
    {
        EnemyScript closest = FindClosest();
        if (closest)
        {
            //if(Vector2.Disctance(transform.position, closest.GetComponent<Transform>().position))
            Debug.Log(name + " Game Object Finded!");

        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject enemy = GameObject.FindWithTag("Enemy");
        //if(collision.gameObject.TryGetComponent<EnemyScript>(out EnemyScript enemy))
        _enemys.Add(enemy);        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject enemy = GameObject.FindWithTag("Enemy");
        //if (collision.gameObject.TryGetComponent<EnemyScript>(out EnemyScript enemy))
        _enemys.Remove(enemy);
    }


    public void ShoutEnemy()
    {




    }*/


    /*private EnemyScript FindClosest()
    {
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (var item in _enemys)
        {
            if(item)
            {
                Vector3 diff = item.position - position;
                float currDistance = diff.sqrMagnitude;
                if(currDistance < distance) 
                {
                    _closest= item;
                    distance = currDistance;
                }
            }
        }

        return _closest;
    }*/
}
