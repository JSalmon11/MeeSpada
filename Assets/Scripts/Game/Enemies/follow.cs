using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform ObjectToFollow = null;
    public float Speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //ObjectToFollow = GameObject.FindGameObjectsWithTag("Player").GetComponent <Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectToFollow==null)
        {
            return;
            transform.position = Vector2.MoveTowards(transform.position, ObjectToFollow.position, Speed * Time.deltaTime);
            transform.up = ObjectToFollow.position - transform.position;
        }
    }
}
