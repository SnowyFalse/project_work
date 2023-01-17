using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Objects
{
    CUBE,
    SPHERE,
    NONE
}
public class SpawnerScript : MonoBehaviour
{
    
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject overlay;
    public GameObject cubeOutline;
    public GameObject sphereOutline;
    
    public static string objectID;
    
    
    public static bool overlayActive = false;
    
    private Vector3 mousePos;
    private Vector3 objectPos;
    
    void Update()
    {
        Objects currentObject = CheckObjectId(objectID);
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            overlayActive = !overlayActive;
            overlay.SetActive(overlayActive);
            
        }

        if (!overlayActive)
        {
            cubeOutline.SetActive(false);
            sphereOutline.SetActive(false);
        }

        if (overlayActive && Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            mousePos = Input.mousePosition;
            mousePos.z = 2.0f;
            objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            
            switch (currentObject)
            {
                case Objects.CUBE: 
                    Debug.Log("Spawn cube");
                    Instantiate(cubePrefab, objectPos, Quaternion.identity);
                    break;
                case Objects.SPHERE:
                    Debug.Log("Spawn sphere");
                    Instantiate(spherePrefab, objectPos, Quaternion.identity);
                    break;
                default:
                    Debug.LogError("Something went wrong");
                    break;
            }
        }
    }

    private Objects CheckObjectId(string objectID)
    {
        // If you want to run the game without the rfid reader uncomment one of the line below
            
        // Uncomment the line below for getting the id for the cube
        //objectID = "670093BEAFE5";
            
        // Uncomment he line below for getting the id for the sphere
        // objectID = "67009C404AF1";

        switch (objectID)
        {
            case "011396FAC8B6":
                if (overlayActive)
                {
                    cubeOutline.SetActive(true);
                    sphereOutline.SetActive(false);
                }
                return Objects.CUBE;
            case "011396EA523C":
                if (overlayActive)
                {
                    sphereOutline.SetActive(true);
                    cubeOutline.SetActive(false);
                }
                return Objects.SPHERE;
            default:
                return Objects.NONE;
        }
    }

}
