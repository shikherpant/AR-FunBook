using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scooter : MonoBehaviour
{
    Vector3 movement;// Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(0.07f, 0, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement * Time.deltaTime);
    }
}
