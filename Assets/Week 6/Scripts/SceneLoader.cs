using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentScneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentScneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void LoadWeek5Scene()
    {
        SceneManager.LoadScene(0);
    }
}
