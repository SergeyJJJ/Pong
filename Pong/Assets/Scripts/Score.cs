using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int _rightPlayerScore;
    [SerializeField] private int _leftPlayerScore;
    
    public void AddRightPlayerScore()
    {
        _rightPlayerScore++;
        Debug.Log(_rightPlayerScore);
    }

    public void AddLeftPlayerScore()
    {
        _leftPlayerScore++;
        Debug.Log(_leftPlayerScore);
    }
}
