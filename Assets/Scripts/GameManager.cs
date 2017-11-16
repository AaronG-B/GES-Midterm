using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List<GameObject> Pickups;

    //public static GameManager instance = null;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        Pickups.Clear();
    }

    // Use this for initialization
    void Start () 
    {
        Pickups.AddRange(GameObject.FindGameObjectsWithTag("Pickup"));


    }

    // Update is called once per frame
    void Update () {
		
	}

    public void ResetPickups()
    {
        foreach (GameObject p in Pickups)
        {
            p.GetComponent<SpriteRenderer>().enabled = true;
            p.GetComponent<PolygonCollider2D>().enabled = true;
            Debug.Log("This worked");
        }
    }
}
