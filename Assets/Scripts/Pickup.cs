using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {


    private SpriteRenderer spriteRenderer;
    private PolygonCollider2D polyCollider;
    private AudioSource audioSource;

    private void OnPlayerRespawnFromCheckpoint()
    {
        SetActive();
    }

    private void OnEnable()
    {
        Hazard.PlayerRespawnFromCheckpoint += OnPlayerRespawnFromCheckpoint;

    }

    private void OnDisable()
    {
        Hazard.PlayerRespawnFromCheckpoint -= OnPlayerRespawnFromCheckpoint;
    }

    public void SetActive()
    {
        spriteRenderer.enabled = true;
        polyCollider.enabled = true;
    }



    // Use this for initialization
	void Start () 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        polyCollider = GetComponent<PolygonCollider2D>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
    {

        transform.Rotate(0, 1 ,0);
		
	}



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spriteRenderer.enabled = false;
            polyCollider.enabled = false;
            audioSource.Play();
        }
    }
}
