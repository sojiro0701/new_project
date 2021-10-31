using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerAC : MonoBehaviour
{
    public GameObject[] playerA;
    public static bool change;

    // Start is called before the first frame update
    void Start()
    {
        change = false;
        gameObject.tag = "enemy";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void move()
    {
        if (.gameObject.tag == "player")
        {
            if (change == false)
            {
                gameObject.tag = "player";
            }
            else
            {

            }
        }
        if (.gameObject.tag == "enemy")
        {
            if (change == false)
            {

            }
            else
            {
                gameObject.tag = "player";
            }
        }
    }
}
