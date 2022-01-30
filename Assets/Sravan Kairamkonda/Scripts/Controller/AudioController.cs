using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IPG_CW2
{
    public class AudioController : MonoBehaviour
    {
        #region Components

        private AudioSource audioSource;

        #endregion Components

        #region Unity Methods

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        #endregion Unity Methods

        #region Methods
        public void PlayShootSound()
        {
            audioSource.Play();
        }

        #endregion Methods
    }
}