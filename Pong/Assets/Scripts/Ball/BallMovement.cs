using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _xDirection;
    private float _yDirection;

    private void Start()
    {
        RandomSpawnDirection();
    }

    private void Update()
    {
        transform.Translate(new Vector2(_xDirection, _yDirection).normalized * Time.deltaTime * _speed, Space.World);
    }

    private void RandomSpawnDirection()
    {
        int xMin = 6, xMax = 11;
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
        
    }
}
