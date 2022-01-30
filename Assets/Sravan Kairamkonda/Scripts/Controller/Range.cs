using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class Range : MonoBehaviour
    {
        #region Members
        public GameManager GameManager;

        public GameObject bullet;

        private LineRenderer lineRenderer;

        #endregion Members

        #region Unity Methods

        /// <summary>
        /// Geth the line renderer component 
        /// </summary>
        private void Awake()
        {
            lineRenderer = this.transform.GetChild(0).GetComponent<LineRenderer>();
        }

        /// <summary>
        /// check the enemy and rotate the player to shoot the player
        /// </summary>
        /// <param name="collision"></param>
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision != null)
            {
                lineRenderer.material.color = Color.red;
            }

            GameManager.shootController.InstantiateBullet(bullet, collision.transform);
            GameManager.player.RotatePlayer(collision.transform);
        }

        #endregion Unity Methods
    }
}