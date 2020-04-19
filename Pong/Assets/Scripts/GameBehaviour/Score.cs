using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    [SerializeField] private int _rightPlayerScore = 0;
    [SerializeField] private int _leftPlayerScore = 0;

    public int LeftPlayerScore
    { 
        get
        {
            return _leftPlayerScore;
        }

        set
        {
            _leftPlayerScore = value;
        }
    }

    public int RightPlayerScore
    { 
        get
        {
            return _rightPlayerScore;
        }

        set
        {
            _rightPlayerScore = value;
        }
    }
    
    private void Update()
    {
        string textToDisplay = $"{_rightPlayerScore}  :  {_leftPlayerScore}";
        _text.SetText(textToDisplay);   
    }

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
