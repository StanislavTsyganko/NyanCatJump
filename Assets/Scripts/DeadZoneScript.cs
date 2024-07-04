using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private PlayerMovement player;

    private void Update()
    {
        if (_target.position.y <= transform.position.y)
        {
            player.Dead?.Invoke();
        }
    }
}