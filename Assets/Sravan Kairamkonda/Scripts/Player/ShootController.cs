using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class ShootController : MonoBehaviour
    {


        /// <summary>
        /// GameObject to hold the bullet prefab.
        /// </summary>
        public GameObject bullet;

        /// <summary>
        /// Parent to hold the bullets.
        /// </summary>
        public Transform ammunation;

        /// <summary>
        /// Bullet Spawn position
        /// </summary>
        public Transform gunNozzle;


        private AudioController audioController;
        private Animator animator;


        private void Awake()
        {
            audioController = GetComponent<AudioController>();
            animator = this.transform.GetChild(0).GetComponent<Animator>();
        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                InstantiateBullet(bullet, gunNozzle);
            }
        }

        public void InstantiateBullet(GameObject prefab, Transform target)
        {
            audioController.PlayShootSound();
            animator.SetTrigger("Recoil");
            GameObject temp = Instantiate(prefab, target.transform.position, target.transform.rotation);
            temp.GetComponent<Rigidbody2D>().AddForce(gunNozzle.transform.up * 10, ForceMode2D.Impulse);
            temp.transform.SetParent(ammunation.transform);
        }

    }
}