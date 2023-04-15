using UnityEngine;

public class DeadPoint : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private GameObject _panelGameOver;

    private void Start()
    {
        _panelGameOver.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (_target.position.y <= transform.position.y)
        {
            _panelGameOver.SetActive(true);
        }
    }
}
