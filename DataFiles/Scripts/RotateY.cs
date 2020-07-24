using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 movement;
    void Start()
    {
        movement = new Vector3(0, 30, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movement * Time.deltaTime);
    }
}
