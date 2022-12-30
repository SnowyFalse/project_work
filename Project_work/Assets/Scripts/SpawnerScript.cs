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
            Debug.Log("Space key pressed with " + objectID);
            if (objectID.Equals("670093BEAFE5"))
            {
                Debug.Log("Spawn cube");
                Instantiate(cubePrefab, transform.position, Quaternion.identity);
            } else if (objectID.Equals("67009C404AF1"))
            {
                Debug.Log("Spawn sphere");
                Instantiate(spherePrefab, transform.position, Quaternion.identity);
            }
            else
            {
                Debug.Log("Something went wrong");
            }
            /*
            switch (objectID)
            {
                case "670093BEAFE5": 
                    Debug.Log("Spawn cube");
                    Instantiate(cubePrefab, transform.position, Quaternion.identity);
                    break;
                case "67009C404AF1":
                    Debug.Log("Spawn sphere");
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    break;
            }
            */
            
        }
    }

}
