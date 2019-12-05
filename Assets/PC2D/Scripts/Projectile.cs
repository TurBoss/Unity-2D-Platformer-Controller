using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        /* foreach (ContactPoint2D contact in col.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        Debug.Log("Collision");
        //all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
        if (col.gameObject.tag == "Enemy")
        {

        }
        */
        // Destroy(col.gameObject);
        //add an explosion or something
        //destroy the projectile that just caused the trigger collision
        Destroy(gameObject, 0.1f);
    }

}
