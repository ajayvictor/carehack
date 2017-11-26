using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider : MonoBehaviour {
  Animator anim;
    float speed = 0.3f;
    Rigidbody rb;
    bool walk = false;
    float timer=5.0f;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        walk = false;
        
	}
	
	// Update is called once per frame
	void Update () {
		if(!walk){
        timer-=Time.deltaTime;
            if(timer<=0){
                walk=true;
            }
        }
        if(walk){
            anim.SetFloat("walkk",1.0f);
       transform.Translate(Vector3.forward*speed*Time.deltaTime);
         
        }
	}


}
