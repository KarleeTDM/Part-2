using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderAssignment : MonoBehaviour
{
    public void LoadCustomizeScene()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(5);
    }
}
