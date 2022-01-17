using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Text progresstext;
    public Slider loading;
    float maxtime = 100f;
    float loadvalue = 0f;
    

    void Start()
    {
        loading.maxValue = maxtime;
        StartCoroutine("load");   
    }

    IEnumerator load()
    {
        while (true)
        {
            yield return new WaitForSeconds(.1f);
            if (loadvalue <= 100f)
            {
                loadvalue++;
                loading.value = loadvalue;
                progresstext.text = loadvalue.ToString("F0") + "%";

                if (loadvalue == 100f)
                {
                    StopCoroutine("load");
                   
                    if(SceneManager.GetActiveScene().buildIndex == 0) {
                        PlayerPrefs.SetInt("clear_level", 0);
                        SceneManager.LoadScene("SCENE1");
                    } else if(SceneManager.GetActiveScene().buildIndex == 2) {
                        if(PlayerPrefs.GetInt("clear_level") == 0) {
                            SceneManager.LoadScene("STAGE1");
                        } else if(PlayerPrefs.GetInt("clear_level") != 0 && (PlayerPrefs.GetInt("clear_level") == 1)) {
                            SceneManager.LoadScene("STAGE2");
                        } else if(PlayerPrefs.GetInt("clear_level") != 0 && (PlayerPrefs.GetInt("clear_level") == 2)) {
                            SceneManager.LoadScene("STAGE3");
                        } else if(PlayerPrefs.GetInt("clear_level") != 0 && (PlayerPrefs.GetInt("clear_level") == 3)) {
                            SceneManager.LoadScene("MAINBOSS");
                        } 
                    } 
                }
            }
        }
      
    }
}
