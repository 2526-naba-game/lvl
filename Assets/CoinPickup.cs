using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int coinValue = 1;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter: " + name);

        Destroy(gameObject);

    }
}
