using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonX : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject charX,R1,R2,StableTree;
    public AudioSource xmasSource;
    public AudioClip xmasClip;
    Vector3 movement;
    bool pressed;
 
    void Start()
    {
        charX.SetActive(false);
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0;i<vrb.Length;i++)
		{
            vrb[i].RegisterEventHandler(this);
		}

        movement = new Vector3(0, 30, 0);
        pressed = false;
      
    }

    // Update is called once per frame
    void Update()
    {
       if(pressed)
        {
            R1.transform.Rotate(movement * Time.deltaTime);
            R2.transform.Rotate(movement * Time.deltaTime);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
        charX.SetActive(true);
        StableTree.SetActive(false);
        pressed = true;
        if(!xmasSource.isPlaying)
		{
            xmasSource.PlayOneShot(xmasClip);
        }
        

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
}
