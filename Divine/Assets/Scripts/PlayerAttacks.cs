using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform fireballDaddy;
    public GameObject fireball;
    public GameObject createdProjectile;
    bool fireballCreated = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !fireballCreated)
        {
            createdProjectile = Instantiate(fireball, fireballDaddy);
            fireballCreated = true;
        }

        if(Input.GetMouseButtonUp(0) && fireballCreated)
        {
            createdProjectile.GetComponent<Projectile>().SendFlying();
            createdProjectile = null;
            fireballCreated = false;
        }
    }
}
