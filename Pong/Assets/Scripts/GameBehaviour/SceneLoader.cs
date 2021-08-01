using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadFirstScene()
    {
        int firstSceneIndex = 0;
        SceneManager.LoadScene(firstSceneIndex, LoadSceneMode.Single);
    }


    public void LoadPreviousScene()
    {
        int previousScene = -1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + previousScene, LoadSceneMode.Single);       
    }


    public void LoadNextScene()
    {
        int nextScene = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + nextScene, LoadSceneMode.Single);       
    }
}
