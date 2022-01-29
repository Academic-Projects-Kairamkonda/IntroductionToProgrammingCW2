using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class GameManager : MonoBehaviour
    {
        public GameObject playerObject;
        public GameObject enemyObject;

        public Player player;
        public ShootController shootController;

        public UIManager uiManager;

        public GameObject enemies;
        public GameObject ammo;

        private void Start()
        {
            QuitGame();
        }

        public void PlayGame()
        {
            playerObject.SetActive(true);
            enemyObject.SetActive(true);

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
            shootController.bulletCount = 10;
        }

        public void DestroyObjects(GameObject obj)
        {
            for (int i = 0; i < obj.transform.childCount; i++)
            {
                Destroy(obj.transform.GetChild(i).gameObject);
            }
        }



    }
}
