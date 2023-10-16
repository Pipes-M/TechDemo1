using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{

    public GameObject endPlat;
    public float duration = 1.0f;
    private Vector3 startPos;
    private Vector3 endPos;
    private float elapsedTime;
    private bool reverse = true;
    









    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }





    void Start()
    {
        
        startPos = transform.position;
        endPos = endPlat.transform.position;
    }


    void Update()
    {
        if (reverse)
        {
            elapsedTime -= Time.deltaTime;

        }
        else
        {
            elapsedTime += Time.deltaTime;
        }
        
        float percentageLerped = elapsedTime / duration;

        transform.position = Vector3.Lerp(startPos, endPos, percentageLerped);

        if (percentageLerped >= 1.0f)
        {
            reverse = true;
        }
        if (percentageLerped <= 0f)
        {
            reverse = false;
        }
    }
}
