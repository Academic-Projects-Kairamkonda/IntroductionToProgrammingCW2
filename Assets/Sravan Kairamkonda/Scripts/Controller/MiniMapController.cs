using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPG_CW2
{
    public class MiniMapController : MonoBehaviour
    {
        #region Members

        public Transform player;

        #endregion Members

        #region Unity Methods

        void Update()
        {
            MiniMapCamera();
        }

        #endregion Unity Methods

        #region Methods
        
        /// <summary>
        /// Mini map camera to show on the canvas
        /// </summary>
        public void MiniMapCamera()
        {
            Vector3 newPosition = player.position;
            newPosition.z = transform.position.z;
            transform.position = newPosition;
        }

        #endregion Methods
    }
}