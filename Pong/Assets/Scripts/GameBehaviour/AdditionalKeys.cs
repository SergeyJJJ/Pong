
using UnityEngine;

public class AdditionalKeys : MonoBehaviour
{
    [SerializeField] private SceneLoader _sceneLoader;


    private void Update()
    {
        PreviousScene();
    }


    private void PreviousScene()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            _sceneLoader.LoadPreviousScene();
        }
    }
}
