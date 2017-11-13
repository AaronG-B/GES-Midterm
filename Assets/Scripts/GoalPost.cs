using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalPost : MonoBehaviour {


    private SpriteRenderer sr;
    private BoxCollider2D bc;
    private AudioSource AudioS;

    public string NextLevelName;


    // Use this for initialization
	void Start () 
    {
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
        AudioS = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () 
    {

        transform.Rotate(1, 0, 0);
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioS.Play();
            SceneManager.LoadScene(NextLevelName);
        }
    }
}
