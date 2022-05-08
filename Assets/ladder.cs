using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{

    [SerializeField]
    Rigidbody2D rc; 
    float speed = 5;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (Input.GetKey(KeyCode.Space))
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
                Debug.Log("Climbing!");

            }
            else if (Input.GetKey(KeyCode.X))
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            }
            else
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
        }
    }


}