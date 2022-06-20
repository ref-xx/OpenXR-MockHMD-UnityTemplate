using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AddToScore : MonoBehaviour
{
    float counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Device:" + XRSettings.loadedDeviceName);
        Debug.Log("is active? " + XRSettings.isDeviceActive);
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == 300)
        {
            counter = 0;
            sc_ScoreManager.townScore.AddScore(0); //just show the numbers.
        }
    }
    // LOOK HERE
    //this is an example to add global score. 
    
    void OnDoSomething()
    {
        //Just use this line to increase player score.
        sc_ScoreManager.townScore.AddScore(10); //Our text space is limited.  Do not increase the score too much!!! :D
    }

    void SendMessageToArmPanel()
    {
            //you want so show some text? use this example:
            counter = 0; //this will reset the 5 second reset.
            sc_ScoreManager.townScore.NotifyPlayer("Hello Player!");
    }


}
