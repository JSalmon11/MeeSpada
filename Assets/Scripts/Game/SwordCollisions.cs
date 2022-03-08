using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollisions : MonoBehaviour
{
    private AudioSource sonido;
    public AudioClip clashSword;
    public AudioClip killSword;
    public float vol = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
         sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision c){
        GameObject ob = GameObject.Find("Sword");
        if(c.collider.name.Equals(ob.name)){
            sonido.PlayOneShot(clashSword, vol);
        }else{
            sonido.PlayOneShot(killSword, vol);
        }
    }
}