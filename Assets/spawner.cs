using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Declare an object to spawn
    public GameObject objectToSpawn;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
