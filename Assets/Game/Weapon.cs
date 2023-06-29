using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public FireButtonA PrimaryFireBtn;
    public GameObject Muzzle;
    public GameObject Proj;

    public float FireRate;
    public float BulletForce;

    float nextFire;

    void Start()
    {
        nextFire = Time.time;
    }

    void FixedUpdate()
    {
        // Check if the player has pressed the fire button and if enough time has elapsed since they last fired
        if (PrimaryFireBtn.buttonPressed && Time.time > nextFire)
        {
            // Update the time when our player can fire next
            nextFire = Time.time + FireRate;

            //
            var clone = Instantiate(Proj, Muzzle.transform.position, Muzzle.transform.rotation);
            var rbc = clone.AddComponent<Rigidbody>();
            rbc.useGravity = false;
            rbc.AddRelativeForce(Vector3.up * BulletForce);
        }
    }
}
