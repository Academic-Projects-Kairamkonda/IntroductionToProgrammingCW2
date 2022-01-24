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
            GameObject temp=Instantiate(bullet,gunNozzle.transform.position,Quaternion.identity);
            temp.transform.SetParent(ammunition.transform);
            temp.GetComponent<Rigidbody2D>().AddForce(gunNozzle.transform.up*1,ForceMode2D.Impulse);
        }
    }
}
