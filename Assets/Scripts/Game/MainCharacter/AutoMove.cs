using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AutoMove : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent navMeshAgent;
    private GameObject[] enemies;

    void Awake(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        navMeshAgent.SetDestination(target.position);
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    private bool TodosMuertos = false;
    void Update()
    {
       if(enemies.Length == 0){
            TodosMuertos = true;
            navMeshAgent.SetDestination(target.position);
       }
    }
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Rute") {
            if(TodosMuertos){
                target = other.gameObject.GetComponent<WayPoint>().nextPoint;
                navMeshAgent.SetDestination(target.position);
            }else{
                navMeshAgent.Stop();
            }
        }

    }

}

