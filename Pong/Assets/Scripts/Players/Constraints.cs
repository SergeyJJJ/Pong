using UnityEngine;

public class Constraints : MonoBehaviour
{
    private float _upperBoundary = 16.3f;
    private float _lowerBoundary = 1.44f;

   
    private void Update()
    {
        ResetPosition();
    }


    private void ResetPosition()
    {
        Vector2 maxYPosition = new Vector2(transform.position.x, _upperBoundary);
        Vector2 minYPosition = new Vector2(transform.position.x, _lowerBoundary);

        if (transform.position.y > _upperBoundary)
        {
            transform.position = maxYPosition;
        }
        else if (transform.position.y < _lowerBoundary)
        {
            transform.position = minYPosition;
        }
    }
}
