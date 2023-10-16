using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jetpackHud : MonoBehaviour
{

    public Slider fuelBar;
    PlayerScript playerScript;



    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    
    void Update()
    {
        fuelBar.value = playerScript.jetFuel;

    }
}
