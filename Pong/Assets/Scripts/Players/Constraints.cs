using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constraints : MonoBehaviour
{
    private float _boundary = 7f;

    // Update is called once per frame
    void Update()
    {
        ResetPosition();
    }

    private void ResetPosition()
    {
        Vector2 maxYPosition = new Vector2(transform.position.x, _boundary);
        Vector2 minYPosition = new Vector2(transform.position.x, -_boundary);

        if (transform.position.y > _boundary)
        {
            transform.position = maxYPosition;
        }
        else if (transform.position.y < -_boundary)
        {
            transform.position = minYPosition;
        }
    }
}
