using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class HoverScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject arrow;
    public GameObject options_menu;
    public GameObject start_menu;
    
    private bool showOptionsMenu = false;
   
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        // Debug.Log("Cursor Entering " + name + " GameObject");
        arrow.SetActive(true);
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        // Debug.Log("Cursor Exiting " + name + " GameObject");
        if (arrow.tag.Equals("arrow"))
        {
            arrow.SetActive(false);  
        }
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SwitchOptions()
    {
        if (options_menu.activeSelf)
        {
            options_menu.SetActive(false);
            start_menu.SetActive(true);
        }
        else
        {
            options_menu.SetActive(true);
            start_menu.SetActive(false);
        }
        
    }
    
}
