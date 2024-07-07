using UnityEngine;
using UnityEngine.AI;

public class EnemyEngine : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    private NavMeshAgent _agent;
    public Transform target;

    private void Awake()
    {
        _enemy = gameObject;
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (_agent.enabled == true)
            MoveToLocation();
    }

    private void MoveToLocation()
    {
        _agent.destination = target.position;
        _agent.isStopped = false;
    }
}
