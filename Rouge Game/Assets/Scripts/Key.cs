using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pickup
{
private GameManager gm;

    // Start is called before the first frame update
    void Start()
    { 
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); //Using the game object game manager and refrencing GameManager script 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gm.AddKey(amount);
            Destroy(gameObject); //Destory whatever object this script is on
        }
    }
}
