using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ÉXÉRÉA
/// </summary>
public class Score : MonoBehaviour
{
    Text _scoreText;
    int _beforeScore;
    public int _score;
    
    void Start()
    {
        _score = 0;
    }

    void Update()
    {
        if (_beforeScore != _score)
        {
            _scoreText.text = _score.ToString();
        }
        _beforeScore = _score;
    }
}
