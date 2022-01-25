using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    /// <summary>
    /// GameObject to hold the bullet prefab.
    /// </summary>
    public GameObject bullet;

    /// <summary>
    /// Parent to hold the bullets.
    /// </summary>
    public Transform ammunition;

    public Transform gunNozzle;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InstantiateBullet(bullet,gunNozzle);
        }
    }

    public void InstantiateBullet(GameObject prefab,Transform target)
    {
        GameObject temp=Instantiate(prefab, target.transform.position, target.transform.rotation);
        temp.GetComponent<Rigidbody2D>().AddForce(gunNozzle.transform.up*10,ForceMode2D.Impulse);
        temp.transform.SetParent(ammunition.transform);
    }

    public void ShootPlayer()
    {
        //Instantiate(bullet);
    }
}
