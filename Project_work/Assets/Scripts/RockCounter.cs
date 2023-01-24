using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RockCounter : MonoBehaviour
{
    
    public TextMeshPro rockCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rockCounter.text = WinCounter.winCounter + "/2";
    }
}
