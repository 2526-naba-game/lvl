using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PippoController : MonoBehaviour
{
    CharacterController _cc;
    // Start is called before the first frame update
    void Start()
    {
       _cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float vMove = Input.GetAxis("Vertical");
        vMove = Mathf.Clamp01(vMove);

        Vector3 direction = transform.forward * vMove * 3;
        _cc.SimpleMove(direction);

        float hMove = Input.GetAxis("Horizontal");
        Vector3 rotation = transform.up * hMove;

        transform.Rotate(rotation);
    }
}
