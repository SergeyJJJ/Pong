using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private Score _score;
    private GameObject _ballSpawn;

    private void Start()
    {
        _score = GameObject.Find("ScoreTracker").GetComponent<Score>();
        _ballSpawn = GameObject.Find("BallSpawn");
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGameOver())
        {
            _ballSpawn.SetActive(false);
        }
    }

    private bool IsGameOver()
    {
        return (_score.RightPlayerScore > 8) || (_score.LeftPlayerScore > 8);
    }
}
