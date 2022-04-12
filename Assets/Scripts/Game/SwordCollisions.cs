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
            if(clashSword != null){
                sonido.PlayOneShot(clashSword, vol);
            }
            new WaitForSeconds(0.8f);
        }else{
            sonido.PlayOneShot(killSword, vol);
            if(c.collider.name.Equals("MainCharacter")){
                killing();
            }
            new WaitForSeconds(0.8f);
        }
    }

        public void killing(){
        if(GameObject.Find("Live3")){
            Destroy(GameObject.Find("Live3"));
        }else if(GameObject.Find("Live2")){
            Destroy(GameObject.Find("Live2"));
        }else if(GameObject.Find("Live1")){
            Destroy(GameObject.Find("Live1"));
            GameObject ob1 = GameObject.Find("MainCharacter");
            Animator anim = ob1.GetComponent<Animator>();
            anim.SetBool("Hit",true);
        }
    }

}