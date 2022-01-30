using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace IPG_CW2
{
    public class CollisionController : MonoBehaviour
    {
        #region Members

        public GameManager GameManager;

        /// <summary>
        /// String holds enemy tag name
        /// </summary>
        public string enemyTag;

        /// <summary>
        /// String hold the ammo tag
        /// </summary>
        public string ammoTag;

        /// <summary>
        /// Health bar Image which is filled type reduced when it is damaged
        /// </summary>
        public Image healthImage;

        #endregion Members

        #region UnityMethods

        /// <summary>
        /// Update the health bar based on the collision
        /// </summary>
        /// <param name="collision">collision of the another object</param>
        private void OnTriggerEnter2D(Collider2D collision)
        { 
            if (collision.gameObject.tag==enemyTag)
            {
                healthImage.fillAmount -= 0.1f;
                Destroy(collision.gameObject); 

                if (healthImage.fillAmount==0)
                {
                    GameManager.QuitGame();
                    GameManager.uiManager.MainPanel();
                    Cursor.lockState = CursorLockMode.None;
                }

                if (healthImage.fillAmount<0.4f)
                {
                    healthImage.color = Color.red;
                }
            }

            if (collision.gameObject.tag==ammoTag)
            {
                this.GetComponent<ShootController>().bulletCount += 3;
                Destroy(collision.gameObject,0.5f);
            }
        }

        #endregion Unity Methods
    }
}