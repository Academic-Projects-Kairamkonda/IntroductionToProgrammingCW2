using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class CollisionController : MonoBehaviour
    {
        public GameManager GameManager;

        public  string enemyTag;

        private void OnTriggerEnter2D(Collider2D collision)
        { 
            if (collision.gameObject.tag==enemyTag)
            {
                GameManager.QuitGame();
                GameManager.uiManager.MainPanel();
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}