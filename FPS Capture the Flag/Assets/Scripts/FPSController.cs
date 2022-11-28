using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    [Header("Player Stats")]
    public float moveSpeed =2f; //movement speed in  units per second
    public float jumpForce; //Force applied to the y axis to make the player jump up
    [Header("Camera Info")]
    public float lookSensitivity; //Mouse look sensitivity 
    public float maxLookX; //Lowest point we can look down 
    public float minLookX; //highest point we can look up 
    public float rotX; //Curret x rotation of the camera
    [Header("Private Variables")]
    private Camera camera; //reference the main camera item in scene
    private Rigidbody rb; //referance the ridgidbody component 

    void Awake()
    {

        //Get Components 
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; //Move Left and Right
        float z = Input.GetAxis("Vertical") * moveSpeed; //Move Forward and Back

        rb.velocity = new Vector3(x, rb.velocity.y, z); //Applies velocity on x and axis. Makes player move
    }
    
    void CameraLook() 
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
    }
}
