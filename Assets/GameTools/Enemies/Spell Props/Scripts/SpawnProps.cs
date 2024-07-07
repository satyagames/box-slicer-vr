using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnProps : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    public Transform target;
    public float propVelocity = 10;
    private bool _isGameOn = true;

    private void OnEnable()
    {
        GameActions.OnGameOver += SetItToFalse;
    }

    private void OnDisable()
    {
        GameActions.OnGameOver -= SetItToFalse;
    }

    private void Start()
    {
        //InvokeRepeating("SpawnARandomProps", 3, 2);
        float m_start = Random.Range(3f, 4.5f);
        Invoke("SpawnARandomProps", m_start);
    }

    private void SpawnARandomProps()
    {
        GameObject m_prop = spawnPrefabs[Random.Range(0, spawnPrefabs.Length)];
        GameObject m_launchedProp = Instantiate(m_prop, this.gameObject.transform.position, this.gameObject.transform.rotation);
        float m_velocity = Random.Range(6.5f, 7.5f);
        Rigidbody m_rb = m_launchedProp.GetComponent<Rigidbody>();
        m_rb.AddForce(this.gameObject.transform.up * propVelocity,ForceMode.Impulse);
        float m_repeat = Random.Range(1.5f, 3f);
        if (_isGameOn)
        {
            Invoke("SpawnARandomProps", m_repeat);
        }        
    }

    private void SetItToFalse()
    {
        _isGameOn=false;
    }

}
