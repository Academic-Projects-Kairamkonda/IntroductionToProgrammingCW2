using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class Enemy : MonoBehaviour
    {
        #region Members
        /// <summary>
        /// Target for the player move towards the player
        /// </summary>
        public Transform target;

        /// <summary>
        /// Speed of the enemy
        /// </summary>
        private float speed;

        /// <summary>
        /// Object holds ammo
        /// </summary>
        public GameObject ammo;

        /// <summary>
        /// Set the whole ammo to this parent
        /// </summary>
        public Transform ammoParent;

        #endregion Members

        #region Unity Methods

        /// <summary>
        /// Update the enemy movement and rotation towards the player
        /// </summary>
        void Update()
        {
            FollowPlayer();
        }

        /// <summary>
        /// Trigger to check the bullet and enemy collision
        /// </summary>
        /// <param name="collision">check the collider of the object</param>
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                this.GetComponent<AudioSource>().Play();
                GameObject temp= Instantiate(ammo,transform.position,Quaternion.identity);
                temp.transform.SetParent(ammoParent);
               
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }

            if (collision.gameObject.tag=="Enemy")
            {
                this.GetComponent<AudioSource>().Play();
                Destroy(collision.gameObject, 0.5f);
            }
        }

        #endregion Unity Methods

        #region Methods
        /// <summary>
        /// Enemy follows the player
        /// </summary>
        public void FollowPlayer()
        {
            speed = 2f;
            speed *= Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);

            var dir = target.position - transform.position;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        }

        #endregion Methods
    }
}