using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace IPG_CW2
{
    public class CollisionController : MonoBehaviour
    {
        public GameManager GameManager;

        public  string enemyTag;
        public string ammoTag;

        public Image healthImage;

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
    }
}