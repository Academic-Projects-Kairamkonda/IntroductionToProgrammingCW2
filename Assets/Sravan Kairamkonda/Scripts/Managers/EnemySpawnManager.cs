using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{

    public class EnemySpawnManager : MonoBehaviour
    {
        public Transform[] enemyPositions;

        public GameManager gameManager;

        public GameObject enemy;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {


        }

        IEnumerator SpawnEnemy()
        {

            yield return null;
        }


    }
}