using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetpackPowerup : MonoBehaviour
{

    PlayerScript playerScript;




    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            playerScript.jetFuel = playerScript.jetFuelMax;
            Destroy(gameObject);

        }
    }





    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    
    void Update()
    {
        
    }
}
