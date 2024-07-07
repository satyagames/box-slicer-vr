using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGameOver : MonoBehaviour
{
    public GameObject clown;
    public GameObject saber;

    private bool _isGameOn = true;

    private void OnEnable()
    {
        GameActions.OnGameOver += ReturnToMenu;
    }

    private void OnDisable()
    {
        GameActions.OnGameOver -= ReturnToMenu;
    }

    public void ReturnToMenu()
    {
        clown.SetActive(true);
        saber.SetActive(false);
        if (_isGameOn)
        {
            SceneTransitionManager.singleton.GoToSceneAsync(0);
            _isGameOn=false;
        }
        
    }
}
