using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelBounds : MonoBehaviour
{

    private Vector3 startPos;
    private Vector3 endPos;
    private float duration = 1.0f;
    private float elapsedTime;
    private bool moveGo = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            //Camera.main.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, Camera.main.transform.position.z);
            startPos = Camera.main.transform.position;
            endPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, Camera.main.transform.position.z);
            moveGo = true;
            
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        if (moveGo)
        {
            elapsedTime += Time.deltaTime;
            float percentageLerped = elapsedTime / duration;

            Camera.main.transform.position = Vector3.Lerp(startPos, endPos, percentageLerped);
            
            if (percentageLerped >= 1f)
            {
                moveGo = false;
                percentageLerped = 0f;
                elapsedTime = 0f;
            }
        }
        
    }
}
