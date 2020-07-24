using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonR : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject rocket;
    Vector3 movement;
    bool pressed;
    Vector3 Originalpos;
    public AudioSource rsource;
    public AudioClip rclip;
    void Start()
    {
        rocket.SetActive(false);
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0;i<vrb.Length;i++)
		{
            vrb[i].RegisterEventHandler(this);
		}
        movement = new Vector3(0, 0.5f, 0);
        pressed = false;
        Originalpos = rocket.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(pressed)
		{
            rocket.transform.Translate(movement * Time.deltaTime);
		}
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
        rocket.SetActive(true);
        pressed = true;
        rocket.transform.localPosition = Originalpos;
        if (!rsource.isPlaying)
        {
            rsource.PlayOneShot(rclip);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
}
