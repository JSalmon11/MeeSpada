using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemieMoves : MonoBehaviour
{
    public Transform player;
    private Animator anim;
    private NavMeshAgent nav;
    private float rangePersecution = 20f;
    private float rangeAttack = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate the distance between two objects
        var heading = player.position - transform.position;
        var distance = heading.magnitude;
        
        //Set the object target of the enemie
        nav.SetDestination(player.position);
        anim.SetInteger("ATK", 0);
        
        if (heading.sqrMagnitude < rangePersecution * rangePersecution) {
            anim.SetBool("walk", true);
            nav.isStopped = false;
        }else{
            anim.SetBool("walk", false);
            nav.isStopped = true;
        }

        if(heading.sqrMagnitude < rangeAttack * rangeAttack){
            anim.SetBool("walk", false);
            nav.isStopped = true;
            int tipoAtaque = Random.Range(0,101);
            anim.SetInteger("ATK", tipoAtaque);
        }
        
    }
}