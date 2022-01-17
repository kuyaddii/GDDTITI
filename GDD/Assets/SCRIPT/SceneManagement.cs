using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string sceneName;

    void Start() {

    }

    public void NavigateToScene() {
        SceneManager.LoadScene(sceneName);
    }
   
}
