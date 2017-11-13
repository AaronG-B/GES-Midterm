using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour {




    GameManager gm;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            aS.Play();
            if (Checkpoint.playerSpawnPoint == null)
            {
               SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                
                collision.gameObject.transform.position = Checkpoint.playerSpawnPoint.position;
                Debug.Log("Go to Checkpoint");
                gm.ResetPickups();

            }


        }


    }

    private AudioSource aS;
    private SpriteRenderer sr;



    // Use this for initialization
    void Start () 

    {
        aS = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();
        sr.enabled = false;
        gm = FindObjectOfType<GameManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
