using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Objects
{
    CUBE,
    SPHERE,
    STAIRS,
    NONE
}
public class SpawnerScript : MonoBehaviour
{
    
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject stairsPrefab;
    public GameObject overlay;
    public GameObject cubeOutline;
    public GameObject sphereOutline;
    public GameObject stairsOutline;
    public GameObject pauseMenu;
    
    public static string objectID;
    
    
    public static bool overlayActive = false;
    public static bool pauseMenuActive = false;

    private Vector3 mousePos;
    private Vector3 objectPos;


    // private void Start()
    // {
    //     var pause = pauseMenu.GetComponentInParent<PauseMenu>();
    //     pause.parent = this;
    // }

    void Update()
    {
        Objects currentObject = CheckObjectId(objectID);
        
        
        
        if (Input.GetKeyDown(KeyCode.E) && !pauseMenuActive)
        {
            FindObjectOfType<AudioManager>().Play("Spawn overlay");
            overlayActive = !overlayActive;
            overlay.SetActive(overlayActive);
            
        }

        if (!overlayActive)
        {
            cubeOutline.SetActive(false);
            sphereOutline.SetActive(false);
            stairsOutline.SetActive(false);
        }

        if (overlayActive && Input.GetKeyDown(KeyCode.Mouse0))
        {
            FindObjectOfType<AudioManager>().Play("Spawn object");
            
            mousePos = Input.mousePosition;
            mousePos.z = 2.0f;
            objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            
            switch (currentObject)
            {
                case Objects.CUBE: 
                    Instantiate(cubePrefab, objectPos, Quaternion.identity);
                    break;
                case Objects.SPHERE:
                    Instantiate(spherePrefab, objectPos, Quaternion.identity);
                    break;
                case Objects.STAIRS:
                    Instantiate(stairsPrefab, objectPos, Quaternion.identity);
                    break;
                default:
                    Debug.LogError("Something went wrong");
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) && !overlayActive)
        {
            pauseMenuActive = !pauseMenuActive;
        } else if (overlayActive && Input.GetKeyDown(KeyCode.Escape))
        {
            overlayActive = !overlayActive;
            overlay.SetActive(overlayActive);
        }
        
        HandlePauseMenu();
    }

    private void HandlePauseMenu()
    {
        pauseMenu.SetActive(pauseMenuActive);
        if (!pauseMenuActive)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
    }

    private Objects CheckObjectId(string objectID)
    {
        // If you want to run the game without the rfid reader uncomment one of the line below
            
        // Uncomment the line below for getting the id for the cube
        // objectID = "011396FAC8B6";
            
        // Uncomment he line below for getting the id for the sphere
        // objectID = "011396EA523C";

        switch (objectID)
        {
            case "0419CE7ACA63":
                if (overlayActive)
                {
                    cubeOutline.SetActive(true);
                    sphereOutline.SetActive(false);
                    stairsOutline.SetActive(false);
                }
                return Objects.CUBE;
            case "0419CD56C94F":
                if (overlayActive)
                { 
                    sphereOutline.SetActive(true);
                    cubeOutline.SetActive(false);
                    stairsOutline.SetActive(false);
                }
                return Objects.SPHERE;
            case "0419CE7BD27A":
                if (overlayActive)
                {
                    stairsOutline.SetActive(true);
                    sphereOutline.SetActive(false);
                    cubeOutline.SetActive(false);
                }
                return Objects.STAIRS;
            default:
                return Objects.NONE;
        }
    }

}
