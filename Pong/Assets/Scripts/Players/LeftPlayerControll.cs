using UnityEngine;

public class LeftPlayerControll : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    
    private void FixedUpdate()
    {
        Move();
    }


    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
    }
}
