using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    // Object to spawn
    public GameObject objectToSpawn;

    // Time to spawn object
    public float time = 3; 

   private float timeCounter = 0;

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter  > time)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            timeCounter = 0;
        }
    }
}
