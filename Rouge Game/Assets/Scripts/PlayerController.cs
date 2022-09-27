using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;  // How fast the player moves
    private float hInput; // Horizontal input
    private float vInput; // Vertical input


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.translate(Vector2.right * hInput * speed * Time.deltaTime); // Move left and right
        transform.translate(Vector2.up* vInput * speed * Time.deltaTime); // Move forward and backwards
    }
}
