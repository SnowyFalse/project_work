using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class HoverScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject arrow;
    public GameObject optionsMenu;
    public GameObject startMenu;
    
   
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        arrow.SetActive(true);
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        if (arrow.tag.Equals("arrow"))
        {
            arrow.SetActive(false);  
        }
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SwitchOptions()
    {
        if (optionsMenu.activeSelf)
        {
            optionsMenu.SetActive(false);
            startMenu.SetActive(true);
        }
        else
        {
            optionsMenu.SetActive(true);
            startMenu.SetActive(false);
        }
        
    }
    
}
