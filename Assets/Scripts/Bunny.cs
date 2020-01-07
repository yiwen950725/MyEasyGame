using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunny : MonoBehaviour
{
    private Vector2 targetPos;
    
    // Update is called once per frame
    public void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            targetPos = new Vector2(transform.position.x, transform.position.y+5);
            transform.position = targetPos;
        }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - 5);
            transform.position = targetPos;
        }

       
    }
}
