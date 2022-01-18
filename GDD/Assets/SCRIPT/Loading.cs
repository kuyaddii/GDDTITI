using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

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
 //                   SceneManager.LoadScene("startMenu");
                }
            }
        }
      
    }
}
