using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class boomerangAttack : MonoBehaviour
{

    
    private Vector3 screenPos;
    private Vector3 worldPos;
    private float elapsedTime;
    private float duration = 0.5f;
    private bool reverse;
    private Vector3 startPos;
    private GameObject player;
    private int timesAtPlayer;



    void Start()
    {
        
        screenPos = Input.mousePosition;
        worldPos = new Vector3(Camera.main.ScreenToWorldPoint(screenPos).x, Camera.main.ScreenToWorldPoint(screenPos).y, 0);
    }


    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startPos = new Vector3(player.transform.position.x, player.transform.position.y, 0);


        
        float percentageLerped = (elapsedTime / duration);

        if (reverse)
        {
            elapsedTime -= Time.deltaTime;

        }
        else
        {
            elapsedTime += Time.deltaTime;
        }

        
        transform.position = Vector3.Lerp(startPos, worldPos, percentageLerped);

        Debug.Log(percentageLerped);


        if (percentageLerped >= 1.0f)
        {
            reverse = true;
        }
        if (percentageLerped <= 0f)
        {
            reverse = false;
            timesAtPlayer += 1;
        }
        if (timesAtPlayer == 2)
        {
            Destroy(gameObject);
        }
    }




    void spawn()
    {


        



    }

}
