using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject arrow;
    public GameObject menu;

    
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

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        SpawnerScript.pauseMenuActive = false;
        menu.SetActive(false);
    }

    public void CloseMenu()
    {
        SpawnerScript.pauseMenuActive = false;
        menu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
