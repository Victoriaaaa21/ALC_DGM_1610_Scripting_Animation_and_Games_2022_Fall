using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameManager gm; // Calls GameManager Script
    public float doorDelay = 0.5f; //How long it will take to open the door

    // Start is called before the first frame update
     void Start()
    {
        gm= GameObject.Find("GameManager").GetComponent<GameManager>(); //Find GameManager object then refrence game script component so we can access its code
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && gm.Key >= 1)
        {
            Destroy(gameObject, doorDelay);
            gm.Key --; //Subtract one key
            Debug.Log("Keys =" + gm.Key); //Troubleshooting feedback
            Debug.Log("Door is Open!");
        }
        else
        {
            Debug.Log("Door is locked. You need a key");
        }
    }
}
