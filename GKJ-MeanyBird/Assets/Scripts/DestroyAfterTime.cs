using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Excecute DestroyObject function based on timetoDestruction
        Invoke("DestroyObject", timeToDestruction);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //After this time, the object will be destroyed
    [Header("Default Destruction Time")]
    public float timeToDestruction;

    //This funtion will destroy this object
    void DestroyObject()
    {
        //Destroy object
        Destroy(gameObject);
    }
}

