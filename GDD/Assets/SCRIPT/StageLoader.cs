using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
public class StageLoader : MonoBehaviour
{
    
    public Sprite[] bgSource;
    public string[] tips = {"Hello", "Hi", "Hey", "GHi"};
    public Image bgImage;
    public Slider loading;
    public Text tipTxt;
    // Start is called before the first frame update
    void Start()
    {
      if(PlayerPrefs.GetInt("clear_level") == 0) {
            bgImage.sprite = bgSource[0];
            tipTxt.text = tips[0];
        } else if(PlayerPrefs.GetInt("clear_level") != 0 && PlayerPrefs.GetInt("clear_level") == 1) {
            bgImage.sprite = bgSource[1];
            tipTxt.text = tips[1];
        } else if(PlayerPrefs.GetInt("clear_level") != 0 && PlayerPrefs.GetInt("clear_level") == 2) {
            bgImage.sprite = bgSource[2];
            tipTxt.text = tips[2];
        } else if(PlayerPrefs.GetInt("clear_level") != 0 && PlayerPrefs.GetInt("clear_level") == 3) {
            bgImage.sprite = bgSource[3];
            tipTxt.text = tips[3];
        } else if(PlayerPrefs.GetInt("clear_level") != 0 && PlayerPrefs.GetInt("clear_level") == 4) {
            bgImage.sprite = bgSource[4];
            tipTxt.text = tips[4];
        } 
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Debug.Log(SceneManager.GetActiveScene().buildIndex);
        
    // }
}
