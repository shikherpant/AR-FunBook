using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 originalpos;
    void Start()
    {
        originalpos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collide)
	{
        if(collide.gameObject.CompareTag("PLANEWALL"))
		{
            transform.localPosition = originalpos;
		}
        else if(collide.gameObject.CompareTag("SCOOTERWALL"))
		{
            transform.localPosition = originalpos;
		}
	}
}
