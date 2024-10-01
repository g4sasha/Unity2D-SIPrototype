using UnityEngine;
using UnityEngine.SceneManagement;

namespace Source.SceneManagement
{
    public class SceneSwitcher : MonoBehaviour
    {
        public void Switch(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}