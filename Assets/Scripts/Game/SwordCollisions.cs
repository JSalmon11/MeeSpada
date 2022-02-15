using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c){
        GameObject ob = GameObject.Find("Sword");
        if(c.collider.name.Equals(ob.name)){
            Debug.Log("illooooooo");
        }
    }
}
