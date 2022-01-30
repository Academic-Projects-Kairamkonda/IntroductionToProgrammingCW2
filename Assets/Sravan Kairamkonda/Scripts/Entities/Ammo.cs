using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class Ammo : MonoBehaviour
    {
        #region Unity Methods

        /// <summary>
        /// plays the audio the ammo when it collided with the player
        /// </summary>
        /// <param name="collision"></param>
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                this.gameObject.GetComponent<AudioSource>().Play();
            }
        }

        #endregion UnityMethods
    }
}
