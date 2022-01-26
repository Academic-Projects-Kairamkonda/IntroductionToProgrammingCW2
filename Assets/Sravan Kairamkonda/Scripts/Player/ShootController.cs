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

        #region Components

        private AudioController audioController;
        private Animator animator;
        public LineRenderer lineRenderer;

        #endregion Components

        private void Awake()
        {
            audioController = GetComponent<AudioController>();
            animator = this.transform.GetChild(0).GetComponent<Animator>();
        }

        void Start()
        {
            lineRenderer.SetPosition(1,new Vector3(0,0,-5));
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                InstantiateBullet(bullet, gunNozzle);
            }
            
            RaycastHit2D hit;

            hit=Physics2D.Raycast(gunNozzle.position,Vector2.down);

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);

                if (hit.collider.gameObject.name=="Enemy")
                {
                   // lineRenderer.SetPosition(1, hit.point);
                }
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