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

        public Transform enemyParent;

        public List<GameObject> enemies= new List<GameObject>();

        public AudioClip blastClip;


        IEnumerator SpawnEnemy()
        {
            while (true)
            {
                GameObject temp=Instantiate(enemyObject);
                int index=Random.Range(0, enemyPositions.Length);
                temp.transform.localPosition = enemyPositions[index].position;
                temp.transform.GetComponent<Enemy>().target = gameManager.player.transform;
                temp.gameObject.name = "Enemy";
                temp.transform.SetParent(enemyParent);
                temp.AddComponent<AudioSource>();
                temp.transform.GetComponent<AudioSource>().playOnAwake = false;


                temp.transform.GetComponent<AudioSource>().PlayOneShot(blastClip);

                yield return new WaitForSeconds(2f);
            }
        }

        public void SpawnEnemies()
        {
            StartCoroutine("SpawnEnemy");
        }


    }
}