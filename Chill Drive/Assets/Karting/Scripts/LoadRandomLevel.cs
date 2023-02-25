using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandomLevel : MonoBehaviour
{

    public int LevelGenerate;
    
    public void LoadTheLevel()
    {
        LevelGenerate = Random.Range(1, 3);
        SceneManager.LoadScene(LevelGenerate);
    }
}
