using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private AudioSource _paddleHitSound;
    [SerializeField] private AudioSource _boundaryhitSound;
    private float _speed = 10f;
    private float _xDirection;
    private float _yDirection;

    private void Start()
    {
        RandomSpawnDirection();
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector2(_xDirection, _yDirection).normalized * Time.deltaTime * _speed, Space.World);
    }

    private void RandomSpawnDirection()
    {
        int xMin = 5, xMax = 11;
        int yMin = 0, yMax = 4;

        _xDirection = Random.Range(xMin, xMax) * RandomSign();
        _yDirection = Random.Range(yMin, yMax) * RandomSign();
    }

    private int RandomSign()
    {
        return Random.Range(1, 3) == 1 ? -1 : 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _xDirection = -_xDirection;
            ChangeYDirection(collision);
            _speed += 0.3f;

            _paddleHitSound.Play();
        }
        else if (collision.gameObject.CompareTag("Boundary"))
        {
            _yDirection = -_yDirection;

            _boundaryhitSound.Play();
        }
    }

    private void ChangeYDirection(Collision paddle)
    {
        float angleChangeCoefficient = 7f;

        float paddleCurrentCenterYPosition = paddle.transform.position.y;
        float collisionPointY = transform.position.y;
        float yDifference = collisionPointY - paddleCurrentCenterYPosition;
        
        _yDirection =+ (yDifference * angleChangeCoefficient);
    }
}
