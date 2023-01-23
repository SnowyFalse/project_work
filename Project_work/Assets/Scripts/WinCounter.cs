using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCounter : MonoBehaviour
{
    
    public int winCounter = 0;

    public static bool canWin = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
