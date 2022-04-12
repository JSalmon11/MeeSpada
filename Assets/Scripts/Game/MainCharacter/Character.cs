using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
	public float movementVel = 3.0f;
	public float rotationVel = 180.0f;

	private Animator anim;
	public float x,y;

	public Rigidbody rb;
	public float jumpStrenght = 4f;
	public bool canJump;

    // Start is called before the first frame update
    void Start()
    {
    	canJump = false;
        anim = GetComponent<Animator>();
    }
    void FixedUpdate ()
    {
    	transform.Rotate(0,x*Time.deltaTime*rotationVel,0);
        transform.Translate(0,0,y*Time.deltaTime*movementVel);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);

        if (canJump==true)
        {
        	if (Input.GetKeyDown(KeyCode.Space))
        	{
        		anim.SetBool("Jump", true);
        		rb.AddForce(new Vector3 (0,jumpStrenght,0), ForceMode.Impulse);
        	}
        	anim.SetBool("Floor", true);
        }else
         {
         	 Falling();
         }
    }
    private void Falling()
    {
    	anim.SetBool("Floor", false);
    	anim.SetBool("Jump", false);
    }
}