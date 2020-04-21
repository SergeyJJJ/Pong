using System.Collections;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private Score _score;
    [SerializeField] private SceneLoader _sceneLoader;
    public bool IsAlive { get; set; } = false;
    private Vector2 _spawnPosition = new Vector2(0, 9);

    private void FixedUpdate()
    {
        if (IsGameOver())
        {
            DisableSpawn();
            _sceneLoader.LoadNextScene();
        }
        else if (!IsAlive)
        {
            StartCoroutine(SpawnNewBall());
        }
    }

    IEnumerator SpawnNewBall()
    {
        IsAlive = true;

        yield return new WaitForSeconds(1.5f);

        Instantiate(_ball, _spawnPosition, _ball.transform.rotation);
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
