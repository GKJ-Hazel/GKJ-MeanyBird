using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        //Trasnform the object to move to left
        //according to the axis and speed
        transform.position += Vector3.left * speed * Time.deltaTime;

    }

    [Header("Default Speed")]
    //Speed for the movement
    public float speed;
}
