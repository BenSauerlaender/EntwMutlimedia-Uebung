using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour
{
    VirtualButtonBehaviour[] mVirtualButtonBehaviours;

    [SerializeField] private Transform spieler;
    void Awake()
    {
        // Register with the virtual buttons ObserverBehaviour
        mVirtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        Debug.Log("VB: " +  mVirtualButtonBehaviours.Length);

        for (var i = 0; i < mVirtualButtonBehaviours.Length; ++i)
        {
            mVirtualButtonBehaviours[i].RegisterOnButtonPressed(OnButtonPressed);
            
        }
    }

    void Destroy()
    {
        Debug.Log("VB destroy");
        // Register with the virtual buttons ObserverBehaviour
        mVirtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (var i = 0; i < mVirtualButtonBehaviours.Length; ++i)
        {
            mVirtualButtonBehaviours[i].UnregisterOnButtonPressed(OnButtonPressed);
        }
    }


public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
        switch(vb.VirtualButtonName){
            case "VirtualButtonUp":
                spieler.GetComponent<Spieler>().move(0f,0.1f);
                break;
            case "VirtualButtonDown":
                spieler.GetComponent<Spieler>().move(0f,-0.1f);
                break;
            case "VirtualButtonRight":
                spieler.GetComponent<Spieler>().move(0.1f,0f);
                break;
            case "VirtualButtonLeft":
                spieler.GetComponent<Spieler>().move(-0.1f,0f);
                break;
        }
        
    }
   
}
