using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Key;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddKey(int amount)
    {
        Key += amount; // could also be coded as key = key + amount.. Adds keys to inventory
        Debug.Log("You have "+ Key + " keys");
    }
}
