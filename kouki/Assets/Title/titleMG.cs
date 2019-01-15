using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class titleMG : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     

    }
    public void startButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Demo_Scene");
        }
    }
    public void sousaButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Demo_Scene");
        }
    }
    public void EndButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }
}
