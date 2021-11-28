using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollider : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player" && player.gameObject.tag == "enemy") //Sphere Colliderの時
        {
            playerA1.target = collision.gameObject;
        }
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "player" && player.gameObject.tag == "enemy") //Sphere Colliderの時
        {
            playerA1.running = true;
        }
    }
    private void OnCTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "player" && player.gameObject.tag == "enemy") //Sphere Colliderの時
        {
            playerA1.running = false;
        }
    }
}
