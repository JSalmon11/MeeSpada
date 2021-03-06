using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollisionsMainCh : MonoBehaviour
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
            if(clashSword != null){
                sonido.PlayOneShot(clashSword, vol);
            }
            //new WaitForSeconds(0.9f);
        }else{
            sonido.PlayOneShot(killSword, vol);
            string otherObjetTag = c.collider.gameObject.tag;
            if(otherObjetTag.Substring(0,5) == "Enemy"){
                killingEnemie(c.collider.gameObject);
            }
            //new WaitForSeconds(0.9f);
        }
    }

    public void killingEnemie(GameObject death){
        death.GetComponent<EnemieMoves>().enabled = false;
        Animator anim = death.GetComponent<Animator>();
        anim.SetBool("Death",true);
    }

}