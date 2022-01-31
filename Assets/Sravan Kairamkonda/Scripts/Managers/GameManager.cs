using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class GameManager : MonoBehaviour
    {
        #region Members

        public GameObject playerObject;
        public GameObject enemyObject;

        public Player player;
        public ShootController shootController;

        public UIManager uiManager;

        public GameObject enemies;
        public GameObject ammo;

        #endregion Members

        #region Unity Methods

        private void Start()
        {
            QuitGame();
        }

        #endregion Unity Methods

        #region Methods

        /// <summary>
        /// Reset the whole data in the game.
        /// </summary>
        public void PlayGame()
        {
            playerObject.SetActive(true);
            enemyObject.SetActive(true);
            player.GetComponent<CollisionController>().healthImage.fillAmount = 1;
            player.GetComponent<CollisionController>().healthImage.color = Color.green;
            shootController.bulletCount = 10;

            player.gameObject.transform.position = Vector3.zero;

            if (enemyObject)
            {
                 enemyObject.GetComponent<EnemySpawnManager>().SpawnEnemies();
                 Cursor.lockState = CursorLockMode.Locked;
            }
        }

        public void QuitGame()
        {
            playerObject.SetActive(false);
            enemyObject.SetActive(false);
            DestroyObjects(enemies);
            DestroyObjects(ammo);
        }

        public void DestroyObjects(GameObject obj)
        {
            for (int i = 0; i < obj.transform.childCount; i++)
            {
                Destroy(obj.transform.GetChild(i).gameObject);
            }
        }

        #endregion Methods

    }
}
