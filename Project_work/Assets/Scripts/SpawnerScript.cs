using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject overlay;
    public static string objectID;
    private bool overlayActive = false;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            overlayActive = !overlayActive;
            overlay.SetActive(overlayActive);
        }

        if (overlayActive && Input.GetKeyDown(KeyCode.Mouse0))
        {
            // If you want to run the game without the rfid reader uncomment one of the line below
            
            // Uncomment the line below for getting the id for the cube
            objectID = "670093BEAFE5";
            
            // Uncomment he line below for getting the id for the sphere
            // objectID = "67009C404AF1";


            switch (objectID)
            {
                case "670093BEAFE5": 
                    Debug.Log("Spawn cube");
                    Instantiate(cubePrefab, transform.position, Quaternion.identity);
                    break;
                case "67009C404AF1":
                    Debug.Log("Spawn sphere");
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    break;
                default:
                    Debug.Log("Something went wrong");
                    break;
            }
        }
    }

}
