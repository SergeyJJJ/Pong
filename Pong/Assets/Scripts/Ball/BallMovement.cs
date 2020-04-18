using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Rigidbody _palyerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _palyerRigidbody = GetComponent<Rigidbody>();
        Move();
    }

    private void Move()
    {
        _palyerRigidbody.AddForce(CreateRandomDirection() * _moveSpeed, ForceMode.Impulse);
    }

    private Vector2 CreateRandomDirection()
    {
        int xRandom;
        int yRandom;

        do
        {
            xRandom = Random.Range(-4, 5);
            yRandom = Random.Range(-2, 2);
        }while (xRandom == 0 || yRandom == 0);

        return new Vector2(xRandom, yRandom).normalized;
    }

}
