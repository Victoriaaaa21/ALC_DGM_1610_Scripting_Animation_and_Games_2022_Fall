using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //How many clicks before balloon pops
    public float scaleToIncrease = 0.10f; //Scale to increase each time te baloon is clicked (inflating)
    public int scoreToGive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown ()
    {
        //Reduce clicks by one
        clickToPop -= 1;

        //Increase balloon volume
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            //scoreManager.IncreaseScoreText(scoreToGive); 
            Destroy(gameObject);
        }
    }

}