using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private string[] sceneNames = { "Scene0", "Scene1" };

    void Start()
    {
        int randomIndex = Random.Range(0, sceneNames.Length);
        SceneManager.LoadScene(sceneNames[randomIndex]);
    }
}

