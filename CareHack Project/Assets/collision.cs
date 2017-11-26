using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    Vector3 pos = new Vector3(0.25f,0f, 3.133266f);
    public GameObject spidi;
    Animator anim;
    int i = 0;
    public float speed = 0.3f;
    Rigidbody rb;
    bool walk = false;
   public float timer = 5.0f;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        walk = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!walk & (i==0))
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                walk = true;
            }
        }
        if (walk)
        {
            anim.SetFloat("walkk", 1.0f);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            
        }





    }

   void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="stoppt")
        {
           // Destroy(gameObject);
           anim.SetFloat("walkk",-1.0f);
            walk = false;i = 1;
            Debug.Log("Instatiated");
        }
    


      
            
      

    }


}
