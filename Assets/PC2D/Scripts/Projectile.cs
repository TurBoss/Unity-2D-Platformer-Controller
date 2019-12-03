using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public KeyCode keyCodeToStart;
    public GameObject BulletPrefab;
    public Vector2 BulletSpeed;
    public int BulletsInClip;
    public AudioClip GunshotSound;

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
        if (Input.GetKeyDown(keyCodeToStart))
        {
            Shoot();
        }

    }


    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody2D>().AddForce(BulletSpeed * 10);
    }

}

