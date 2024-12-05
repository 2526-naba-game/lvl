using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 3;
    void Start()
    {
        Destroy (gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
