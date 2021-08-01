using UnityEngine;

public class RightPlayerControll : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

   
    private void FixedUpdate()
    {
        Move();
    }


    private void Move()
    {
        if (Input.GetKey(KeyCode.Keypad8))
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.Keypad5))
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
    }
}
