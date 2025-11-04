using UnityEngine;

// Write the BatW6 class here.

public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject target;

    private bool _isChasing = false;

    private void Start()
    {
        speed = 3.0f;
    }

    public void StartChase()
    {
        _isChasing = true;
    }

    public void StopChase()
    {
        _isChasing = false;
    }

    private void Update()
    {
        if (_isChasing && target != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                target.transform.position,
                speed * Time.deltaTime
            );
        }
    }
}
