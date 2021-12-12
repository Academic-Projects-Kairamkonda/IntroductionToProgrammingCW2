using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace IPG_CW2
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField]
        public const string mapSceneName="Playground";
        public const string gameSceneName = "Game";
        public const string sceneName = "Test_Map";

        // Start is called before the first frame update
        void Start()
        {
            SceneManager.LoadScene(mapSceneName,LoadSceneMode.Additive);
            SceneManager.LoadScene(gameSceneName , LoadSceneMode.Additive);
            SceneManager.LoadScene(sceneName , LoadSceneMode.Additive);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}