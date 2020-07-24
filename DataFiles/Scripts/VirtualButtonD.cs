using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonD : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject ani,R;
    Vector3 movement;
    bool pressed;
    public AudioSource SoundSource;
    public AudioClip SoundClip;
    public GameObject hide;
    void Start()
    {
        ani.SetActive(false);
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
            R.transform.Rotate(movement * Time.deltaTime);
		}
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
        ani.SetActive(true);
        hide.SetActive(false);
        pressed = true;
        if (!SoundSource.isPlaying)
        {
            SoundSource.PlayOneShot(SoundClip);
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
}
