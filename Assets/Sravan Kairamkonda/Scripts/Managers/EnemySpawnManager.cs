using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class EnemySpawnManager : MonoBehaviour
    {
        #region Members

        /// <summary>
        /// enemy positioonns
        /// </summary>
        public Transform[] enemyPositions;

        /// <summary>
        /// GameManager has the all objects references
        /// </summary>
        public GameManager gameManager;

        /// <summary>
        /// enemy gameobject
        /// </summary>
        public GameObject enemyObject;

        /// <summary>
        /// it used to set all enemyobject to this as  a parent
        /// </summary>
        public Transform enemyParent;

        /// <summary>
        /// list of enemies
        /// </summary>
        public List<GameObject> enemies= new List<GameObject>();

        /// <summary>
        /// blastclip audio
        /// </summary>
        public AudioClip blastClip;

        /// <summary>
        /// ammo prefab object 
        /// </summary>
        public GameObject ammoObject;

        /// <summary>
        /// as similarly to enemyparent it is used to set as a paret.
        /// </summary>
        public Transform ammoParent;

        #endregion Members

        #region Unity Methods

        /// <summary>
        /// co routines to spawn enemies
        /// </summary>
        /// <returns> wait time to spawn another enemies</returns>
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

                temp.transform.GetComponent<Enemy>().ammo = ammoObject;
                temp.transform.GetComponent <Enemy>().ammoParent=ammoParent;

                temp.AddComponent<AudioSource>();
                temp.transform.GetComponent<AudioSource>().playOnAwake = false;


                temp.transform.GetComponent<AudioSource>().PlayOneShot(blastClip);

                yield return new WaitForSeconds(2f);
            }
        }

        #endregion Unity Methods

        #region Methods

        /// <summary>
        /// spawn enemies 
        /// </summary>
        public void SpawnEnemies()
        {
            StartCoroutine("SpawnEnemy");
        }

        #endregion Methods
    }
}