using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    [HideInInspector] public float jetFuel;
    public float jetFuelLossRate = 0.1f;
    [HideInInspector] public float jetFuelMax = 1f;
    public float jetStr = 5f;

    private Rigidbody2D body;
    private float playerInput;
    private BoxCollider2D boxCollider;
    private RaycastHit2D raycastHit;
    private bool isGrounded;




    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = true;
        }

        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = false;
        }
    }
    




    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
        playerInput = Input.GetAxis("Horizontal");
        
        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, 5);
            
        }
        jetpack();
        
    }

    void FixedUpdate()
    {

        body.velocity = new Vector2(playerInput * speed, body.velocity.y);
        
    }

    void jetpack()
    {
        if (Input.GetKey(KeyCode.Space) && (jetFuel > 0))
        {
            body.velocity = new Vector2(body.velocity.x, jetStr);
            jetFuel -= Time.deltaTime * jetFuelLossRate;
        }
    }

}
