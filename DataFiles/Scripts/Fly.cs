using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    Vector3 movement;// Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(-0.1f, 0.2f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement * Time.deltaTime);
    }
}
