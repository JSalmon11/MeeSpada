using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public Transform movePositionTo;
    private NavMeshAgent navMeshAgent;

    void Awake(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
            navMeshAgent.destination = movePositionTo.position;
    }


}
