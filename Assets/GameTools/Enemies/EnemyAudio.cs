using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAudio : MonoBehaviour
{
    public string clipAudioName;
    private float random = 5;

    public void Start()
    {
        float m_rand = Random.Range(0, 6.5f);
        if(m_rand >= random)
        {
            if (clipAudioName != "")
            {
                AudioManager.instance.Play(clipAudioName);
            }
        }        
    }
}
