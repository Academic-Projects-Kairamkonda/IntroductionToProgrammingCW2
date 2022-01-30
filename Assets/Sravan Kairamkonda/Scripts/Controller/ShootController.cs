using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace IPG_CW2
{
    public class ShootController : MonoBehaviour
    {
        #region Members
        /// <summary>
        /// GameObject to hold the bullet prefab.
        /// </summary>
        public GameObject bullet;

        /// <summary>
        /// bullet count;
        /// </summary>
        public int bulletCount=10;

        /// <summary>
        /// Update the bullets data to the text
        /// </summary>
        public TextMeshProUGUI bulletText;

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

        /// <summary>
        /// player range to shoot the enemy automatically
        /// </summary>
        private const float range = 3f;

        #endregion Members

        #region Unity Methods

        private void Awake()
        {
            audioController = GetComponent<AudioController>();
            animator = this.transform.GetChild(0).GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            bulletText.text ="Ammo: "+bulletCount.ToString();

            if (Input.GetMouseButtonDown(0) && bulletCount > 0) 
            {
                InstantiateBullet(bullet, gunNozzle);
                bulletCount--;
                //this.GetComponent<Player>().silderRotationValue.AngleValue-=5;
            }
            
            RaycastHit2D hit;

            hit=Physics2D.Raycast(gunNozzle.position,gunNozzle.up,range);

            Debug.DrawLine(gunNozzle.position, gunNozzle.up*4f);

            if (hit.collider != null)
            {
                //Debug.Log(hit.collider.gameObject.name);

                float distance=Vector3.Distance(gunNozzle.transform.position,hit.collider.transform.position);

                if (hit.collider.gameObject.name=="Enemy")
                {
                    lineRenderer.SetPosition(1,new Vector3(0,0,-distance));
                }
            }
            else
            {
               lineRenderer.SetPosition(1,new Vector3(0,0,-range));
            }
        }

        #endregion Unity Methods

        #region Methods

        public void InstantiateBullet(GameObject prefab, Transform target)
        {
            audioController.PlayShootSound();
            animator.SetTrigger("Recoil");
            GameObject temp = Instantiate(prefab, target.transform.position, target.transform.rotation);
            temp.GetComponent<Rigidbody2D>().AddForce(gunNozzle.transform.up * 10, ForceMode2D.Impulse);
            temp.transform.SetParent(ammunation.transform);
        }

        #endregion Methods

    }
}