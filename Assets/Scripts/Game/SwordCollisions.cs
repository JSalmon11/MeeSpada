using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollisions : MonoBehaviour
{
    public AudioClip clashSword;
    public AudioClip killSword;
    public float vol = 0.5f;
    public Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c){
        GameObject ob = GameObject.Find("Sword");
        if(c.collider.name.Equals(ob.name)){
            AudioSource.PlayClipAtPoint(clashSword, pos.position, vol);
        }
    }
}