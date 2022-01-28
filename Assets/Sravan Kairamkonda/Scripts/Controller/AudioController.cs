using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IPG_CW2
{
    public class AudioController : MonoBehaviour
    {
        //public AudioClip[] audioClips;

        private AudioSource audioSource;

        [SerializeField]
        public Dictionary<string, AudioClip> audioClipsDict=new Dictionary<string, AudioClip>();

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void PlayShootSound()
        {
            audioSource.Play();
        }
    }
}