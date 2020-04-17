using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private float _xDirection;
    private float _yDirection;
    Vector2 _direction;

    // Start is called before the first frame update
    void Start()
    {
        _xDirection = 1;
        _yDirection = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        _direction = new Vector2(_xDirection, _yDirection);
        transform.Translate(_direction * _moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            _yDirection = -_yDirection;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            _xDirection = -_xDirection;
        }
    }
}
