using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.IO;
using UnityEngine.SceneManagement;

public class RetryBTN : MonoBehaviour
{
  public void LoadGame()
  {
     // SceneManager.LoadScene("Stage1");
    if(PlayerPrefs.GetInt("clear_level") == 0)
    {
        SceneManager.LoadScene("Stage1");
    }
    else if(PlayerPrefs.GetInt("clear_level") != 0 && PlayerPrefs.GetInt("clear_level") == 1)
    {
        SceneManager.LoadScene("Stage2");
    }
    else if(PlayerPrefs.GetInt("clear_level") !=0 && PlayerPrefs.GetInt("clear_level") == 2)
    {
        SceneManager.LoadScene("Stage3");
    }
    else if(PlayerPrefs.GetInt("clear_level") !=0 && PlayerPrefs.GetInt("clear_level") == 3)
    {
        SceneManager.LoadScene("MAINBOSS");
    }

  }
  
}

