using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonT : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject light;
   
    void Start()
    {
        light.SetActive(false);
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0;i<vrb.Length;i++)
		{
            vrb[i].RegisterEventHandler(this);
		}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
        light.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        light.SetActive(false);
    }
}
