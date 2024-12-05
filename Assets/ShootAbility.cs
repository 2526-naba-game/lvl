using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAbility : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
    }
}
