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

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Rute") {
            if(enemies.Length == 0){
                target = other.gameObject.GetComponent<WayPoint>().nextPoint;
                navMeshAgent.SetDestination(target.position);
            }else{
                Debug.Log("porke paras ?");
                navMeshAgent.Stop();
            }
        }

    }

}

