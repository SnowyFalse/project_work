using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinCounter : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Object"))
        {

            FindObjectOfType<AudioManager>().Play("Trap activated");
        }

        if (collision.gameObject.tag.Equals("puzzleGround"))
        {
            FindObjectOfType<AudioManager>().Play("Trap activated");
        }
    }
}
