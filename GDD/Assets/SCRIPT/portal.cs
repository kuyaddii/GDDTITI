using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour {
[SerializeField] private string newlevel;
[SerializeField] private int clearlevel;
// Use this for initialization

void OnTriggerEnter2D(Collider2D other)
{
	if (other.CompareTag("Player"))
	{
		SceneManager.LoadScene(newlevel);
		PlayerPrefs.SetInt("clear_level", clearlevel);
	}
}
}
