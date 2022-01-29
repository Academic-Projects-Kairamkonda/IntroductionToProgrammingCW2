using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class CollisionController : MonoBehaviour
    {
        public GameManager GameManager;

        public  string enemyTag;
        public string ammoTag;

        private void OnTriggerEnter2D(Collider2D collision)
        { 
            if (collision.gameObject.tag==enemyTag)
            {
                GameManager.QuitGame();
                GameManager.uiManager.MainPanel();
                Cursor.lockState = CursorLockMode.None;
            }

            if (collision.gameObject.tag==ammoTag)
            {
                this.GetComponent<ShootController>().bulletCount += 3;
                Destroy(collision.gameObject,0.5f);
            }
        }
    }
}