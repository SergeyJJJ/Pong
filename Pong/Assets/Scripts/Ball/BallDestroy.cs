using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    private Score _score;

    private void Start()
    {
        _score = GameObject.Find("ScoreTracker").GetComponent<Score>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RightTrigger"))
        {
            _score.AddLeftPlayerScore();
        }
        else if (other.gameObject.CompareTag("LeftTrigger"))
        {
            _score.AddRightPlayerScore();
        }
        
        Destroy(gameObject);
    }
}
