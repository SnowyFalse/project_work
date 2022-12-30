using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public static string objectID;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
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
