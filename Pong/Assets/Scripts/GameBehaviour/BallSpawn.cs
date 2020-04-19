using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private Score _score;
    [SerializeField] private SceneLoader _sceneLoader;
    public bool IsAlive { get; set; } = false;

    private void FixedUpdate()
    {
        if (IsGameOver())
        {
            DisableSpawn();
            _sceneLoader.LoadNextScene();
        }
        else if (!IsAlive)
        {
            SpawnNewBall();
        }
    }

    private void SpawnNewBall()
    {
        IsAlive = true;
        Instantiate(_ball, _ball.transform.position, _ball.transform.rotation);
    }

    private bool IsGameOver()
    {
        return (_score.RightPlayerScore > 8) || (_score.LeftPlayerScore > 8);
    }

    private void DisableSpawn()
    {
        gameObject.SetActive(false);
    }
}
