using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    private BallSpawn _ballSpawn; 

    private Score _score;

    private void Start()
    {
        _ballSpawn = GameObject.Find("BallSpawn").GetComponent<BallSpawn>();
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
        
        _ballSpawn.IsAlive = false;
        Destroy(gameObject);
    }
}
