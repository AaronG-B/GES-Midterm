using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {


    public static Transform playerSpawnPoint;

    [SerializeField]
    private float activatedScale;

    [SerializeField]
    private float deactivatedScale;

    [SerializeField]
    private Color activatedColor;

    [SerializeField]
    private Color deactivatedColor;

    private bool isActive = false;
    private SpriteRenderer spriteRenderer;

    AudioSource au;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            ActivateCheckpoint();

        }
    }

    private void ActivateCheckpoint()
    {
        if (isActive == false)
        {
            isActive = true;
            playerSpawnPoint = gameObject.transform;
            transform.localScale = transform.localScale * activatedScale;
            spriteRenderer.color = activatedColor;
            au.Play();
        }
    }

    private void DeactivateCheckpoint()
    {
        isActive = false;
        transform.localScale = Vector3.one * deactivatedScale;
        spriteRenderer.color = deactivatedColor;

    }


    void Start () 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        au = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
