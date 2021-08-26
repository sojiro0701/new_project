using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endtext : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerC.change == true)
        {
            text1.SetActive(true);
            text2.SetActive(false);
        }
        if (playerC.change == false)
        {
            text1.SetActive(false);
            text2.SetActive(true);
        }
    }
}
