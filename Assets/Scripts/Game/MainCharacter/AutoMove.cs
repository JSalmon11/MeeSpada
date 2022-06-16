using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class AutoMove : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent navMeshAgent;
    private GameObject[] enemies;

    private string nameEnemies ;
    void Awake(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Start(){
        navMeshAgent.SetDestination(target.position);
        nameEnemies = "Enemy";
    }

    void Update(){
        if(enemies != null){
            if(enemies.Length == 0){
            navMeshAgent.isStopped = false;
            navMeshAgent.SetDestination(target.position);
            //Gupo eliminado avanzo al suiguiente punto
            }else{
                enemies = GameObject.FindGameObjectsWithTag(nameEnemies);
            }
        }
    }
     
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Rute") {
                target = other.gameObject.GetComponent<WayPoint>().nextPoint;
                enemies = other.gameObject.GetComponent<WayPoint>().enemies;	
                nameEnemies = other.gameObject.GetComponent<WayPoint>().enemyName;
                //si recibe por la variable nameEnemies == "EnemyFin" pues llamas al final y listo
                if(nameEnemies.Equals("EnemyFin")) {
                    navMeshAgent.isStopped = true;// es irrelevante esta linea pero no esta demas.
                    //llamar aqui a la pantall fin.
                    PlayerPrefs.SetString("Points", GameObject.Find("Points").GetComponent<UnityEngine.UI.Text>().text);
                    SceneManager.LoadScene(GameObject.Find("NextLevel").GetComponent<UnityEngine.UI.Text>().text);
                }
                navMeshAgent.isStopped = true;
            }
        }

}



