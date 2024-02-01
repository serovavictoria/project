using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField]
        private int SceneNumber;

        public void LoadScene()
        {
            SceneManager.LoadScene(SceneNumber);
        }
    }
}