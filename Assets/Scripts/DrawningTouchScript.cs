using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;


public class DrawningTouchScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Vector3 start;
    private Vector3 end;
    float timeS, timeE;
    private Vector3 direction;
    private Camera cam;
    private GameObject[] clouds;
    [SerializeField] private GameObject _oblakoPrefab;
    public UnityEvent ShoutEvent;

    private void Awake()
    {
        direction = Vector3.zero;
    }

    void Start()
    {
        cam = Camera.main;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("StaAART: ");
        timeS = eventData.clickTime;
        start = cam.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, 0));
        start = new Vector3(start.x, start.y, 0);
        //Debug.Log(start);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("END: ");
        timeE = eventData.clickTime;
        end = cam.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, 0));
        end = new Vector3(end.x, end.y, 0);
        Debug.Log(end);
        if((end-start).magnitude<0.5)
            ShoutEvent?.Invoke();
        else
            if(timeE-timeS>=0.5)
                SpawnPlatform();
    }

    public void SpawnPlatform()
    {
        //Debug.Log("SpawN: ");
        direction = end - start;
        //Debug.Log(direction);
        //direction = new Vector3(direction.x, 0, direction.z);
        //var angleBetween = Vector3.Angle(start, direction);
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        //Debug.Log(rotation);
        rotation.y = 0;
        rotation.x = 0;
        clouds = GameObject.FindGameObjectsWithTag("Platform");
        foreach (var item in clouds)
        {
            if (item)
            {
                if (item.transform.position.y > start.y)
                    return;
            }
        }

        Instantiate(_oblakoPrefab, start, rotation);
    }

}
