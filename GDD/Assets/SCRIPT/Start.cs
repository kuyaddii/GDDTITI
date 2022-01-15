using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

public void Stage1()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
}
    }

