using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    public bool IsAlive { get; set; } = false;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (!IsAlive)
        {
            SpawnNewBall();
        }
    }

    private void SpawnNewBall()
    {
        IsAlive = true;
        Instantiate(_ball, _ball.transform.position, _ball.transform.rotation);
    }
}
