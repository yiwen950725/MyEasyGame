using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bunny2"))
        {
            other.GetComponent<bunny2>().health -= damage;
            Debug.Log(other.GetComponent<bunny2>().health);
            Destroy(gameObject);
        }
    }


}
