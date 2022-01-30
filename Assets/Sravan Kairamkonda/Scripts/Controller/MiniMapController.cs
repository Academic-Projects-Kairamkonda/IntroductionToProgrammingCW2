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
            Vector3 newPosition = player.position;
            newPosition.z = transform.position.z;
            transform.position = newPosition;
        }

        #endregion Unity Methods
    }
}