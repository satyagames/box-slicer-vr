using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private int _score = 0;
    private int _life = 10;

    public TMP_Text scoreText;
    public TMP_Text lifeText;

    private void OnEnable()
    {
        GameActions.OnPropCut += AddScore;
        GameActions.OnPropGrounded += MinusLife;
    }

    private void OnDisable()
    {
        GameActions.OnPropCut -= AddScore;
        GameActions.OnPropGrounded -= MinusLife;
    }

    public void AddScore()
    {
        _score += 20;
        scoreText.text = _score.ToString();
        Debug.Log(_score);
    }

    public void MinusLife()
    {
        _life -= 1;
        lifeText.text = _life.ToString();
        if( _life <= 0 )
        {
            GameActions.OnGameOver?.Invoke();
        }
    }
}
