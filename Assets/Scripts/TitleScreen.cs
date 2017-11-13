using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

	
    public void StartButtonClicked()
    {
        SceneManager.LoadScene("Level1");
    }

    public void CreditsButtonClicked()
    {
        SceneManager.LoadScene("Credits");
    }

    public void BackButtonClicked()
    {
        SceneManager.LoadScene("Title Screen");
    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
