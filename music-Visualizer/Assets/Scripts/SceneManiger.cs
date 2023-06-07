using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManiger : MonoBehaviour
{
    public int sceneIndex = 1;
    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
