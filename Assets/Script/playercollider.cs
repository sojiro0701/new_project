using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player" && this.gameObject.tag == "enemy") //Sphere Colliderの時
        {
            playerA1.target = collision.gameObject;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "player" && this.gameObject.tag == "enemy") //Sphere Colliderの時
        {
            playerA1.running = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "player" && this.gameObject.tag == "enemy") //Sphere Colliderの時
        {
            playerA1.running = false;
        }
    }
}
