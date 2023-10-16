using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platBreak : MonoBehaviour
{
    private GameObject player;
    private bool canBreak;
    public float time = 3;



    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            canBreak = true;
        }
    }




    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        if (canBreak)
        {
            time -= Time.deltaTime;
            if (time < 0 )
            {
                Destroy(gameObject);
            }
        }
    }
}
