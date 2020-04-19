using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int nextScene = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + nextScene, LoadSceneMode.Single);       
    }

    public void LoadFirstScene()
    {
        int firstSceneIndex = 0;
        SceneManager.LoadScene(firstSceneIndex, LoadSceneMode.Single);
    }
}
