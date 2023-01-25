using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinCounter2 : MonoBehaviour
{
    public int winCounter;
    public int overallWinCounter;
    
    public Text rockCounter;
    public GameObject rockImage;

    public static bool canWin = false;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("WIN COUNTER: " + winCounter);
        //overallWinCounter = winCounter + WinCounter2.winCounter2;
        if (winCounter >= 2)
        {
            rockCounter.text = "Portal opened!";
            canWin = true;
        }
        else
        {
            rockCounter.text = winCounter + "/2 in position WORK";
        }

        if (SpawnerScript.overlayActive || SpawnerScript.pauseMenuActive)
        {
            rockCounter.text = "";
            rockImage.SetActive(false);
        }
        else
        {
            rockImage.SetActive(true);
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Object"))
        {

            winCounter++;
            FindObjectOfType<AudioManager>().Play("Trap activated");
        }

        if (collision.gameObject.tag.Equals("puzzleGround"))
        {
            FindObjectOfType<AudioManager>().Play("Trap activated");
        }
    }
}
