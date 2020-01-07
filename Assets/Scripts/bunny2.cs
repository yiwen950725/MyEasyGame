using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bunny2 : MonoBehaviour
{
    private Vector2 targetPos;
    public float YIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;


    private void Start()
    {
        targetPos = new Vector2(transform.position.x, transform.position.y);
    }
    // Update is called once per frame
    private void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + YIncrement);
            //transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - YIncrement);
            //transform.position = targetPos;
        }


    }
}
