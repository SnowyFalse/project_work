using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinCounter : MonoBehaviour
{
    
    public static int winCounter = 0;

    public static bool canWin = false;

    // Update is called once per frame
    void Update()
    {
        if (!canWin && winCounter >= 2)
        {
            canWin = true;
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Object"))
        {
            Debug.Log("winCounter: " + winCounter);
            winCounter++;
        }
    }
}
