using UnityEngine;
using System.Collections;

public class ShortLived : MonoBehaviour
{
    public GameObject Bullet_Emitter;
    public GameObject Bullet;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;


            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();


            //Bullets disappear after 3 seconds
            Destroy(Temporary_Bullet_Handler, 3.0f);
        }
    }
}