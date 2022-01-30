using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace IPG_CW2
{
    public class UIManager : MonoBehaviour
    {
        #region Members

        private AudioSource uiAudioSource;
        
        public GameObject defaultPanel;
        public GameObject mainPanel;
        public GameObject optionsPanel;
       
        public GameObject miniMapPanel;

        public GameManager gameManager;

        public AudioClip clickAudio;
        public AudioClip switchAudio;
        public AudioClip backAudio;

        #endregion Members

        #region UnityMethods

        private void Awake()
        {
            uiAudioSource = GetComponent<AudioSource>();
        }

        void Start()
        {
            MainPanel();
        }


        #endregion Unity Methods

        #region Methods
        public void MainPanel()
        {
            defaultPanel.SetActive(true);
            mainPanel.SetActive(true);
            optionsPanel.SetActive(false);
            miniMapPanel.SetActive(false);
        }

        public void OptionalPanel()
        {
            defaultPanel.SetActive(true);
            mainPanel.SetActive(false);
            optionsPanel.SetActive(true);
        }

        public void DisableAllPanels()
        {
            defaultPanel.SetActive(false);
            mainPanel.SetActive(false);
            optionsPanel.SetActive(false);
        }

        public void ClickSound()
        {
            uiAudioSource.clip = clickAudio;
            uiAudioSource.Play();
        }

        public void SwitchSound()
        {
            uiAudioSource.clip = switchAudio;
            uiAudioSource.Play();
        }

        public void BackSound()
        {
            uiAudioSource.clip=backAudio;
            uiAudioSource.Play();
        }

        public void Play()
        {
            gameManager.PlayGame();
        }

        #endregion Methods
    }
}