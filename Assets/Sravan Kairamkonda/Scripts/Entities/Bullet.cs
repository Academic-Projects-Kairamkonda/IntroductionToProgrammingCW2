using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class Bullet : MonoBehaviour
    {
        #region Unity Methods
        /// <summary>
        /// Destroys the bullet when it moves out of the camera bounds
        /// </summary>
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

        #endregion Unity Methods
    }
}