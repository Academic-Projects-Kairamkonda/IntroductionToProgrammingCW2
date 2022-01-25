using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class EnemySpawnManager : MonoBehaviour
    {
        public Transform[] enemyPositions;

        public GameManager gameManager;

        public GameObject enemyObject;

        void Start()
        { 
            StartCoroutine("SpawnEnemy");
            
        }

        IEnumerator SpawnEnemy()
        {
            while (true)
            {
                GameObject temp=Instantiate(enemyObject);
                int index=Random.Range(0, enemyPositions.Length);
                temp.transform.localPosition = enemyPositions[index].position;
                temp.transform.GetComponent<Enemy>().target = gameManager.player.transform;

                yield return new WaitForSeconds(2f);
            }
        }


    }
}