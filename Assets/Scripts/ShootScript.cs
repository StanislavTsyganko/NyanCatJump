using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    private GameObject[] _enemys;
    private GameObject _closest;
    private GameObject _bullet;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Image ImageStar;
    [SerializeField] private float maxTimer;
    private float timer;


    public void Shout()
    {
        _enemys = GameObject.FindGameObjectsWithTag("Enemy");
        _closest = FindClosest();
        if (_closest)
        {
            if (timer <= 0)
            {
                ImageStar.color = new Color(255, 255, 255, 0.7f);
                Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
                _bullet = GameObject.FindWithTag("Bullet");
                timer = maxTimer;
            }
        }
    }

    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && ImageStar)
            ImageStar.color = new Color(255, 255, 255, 1);

        if (_closest && _bullet)
        {
            if (_bullet.transform.position == _closest.transform.position)
                Destroy(_bullet);   
            _bullet.transform.position = Vector2.MoveTowards(_bullet.transform.position, _closest.transform.position, 0.5f);
        }
    }


    GameObject FindClosest()
    {
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (var item in _enemys)
        {
            if (item)
            {
                Vector3 diff = item.transform.position - position;
                float currDistance = diff.sqrMagnitude;
                if (currDistance < distance)
                {
                    _closest = item;
                    distance = currDistance;
                }
            }
        }

        return _closest;
    }
}
