using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]private AudioSource _goalSound;
    [SerializeField]private Text _text;

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
       DisplayScore();  
    }

    private void DisplayScore()
    {
        string textToDisplay = $"{_rightPlayerScore}    {_leftPlayerScore}";
        _text.text = textToDisplay;  
    }

    public void AddRightPlayerScore()
    {
        _rightPlayerScore++;
        _goalSound.Play();
    }

    public void AddLeftPlayerScore()
    {
        _leftPlayerScore++;
        _goalSound.Play();
    }
}
