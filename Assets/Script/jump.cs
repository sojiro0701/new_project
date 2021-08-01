using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public static bool jumpup;

    // Start is called before the first frame update
    void Start()
    {
        bool jumpup = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floer")
        {
            jump.jumpup = true;
        }
    }
}
    
