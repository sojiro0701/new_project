using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endbotton : MonoBehaviour
{
    public Text text1;
    public Text text2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerC.change == false)
        {
            text1.text = "You Win";
            text1.color = Color.red;
        }
        if (playerC.change == true)
        {
            text2.text = "You Lose";
            text2.color = Color.blue;
        }
    }

    public void OnClickendbotton()
    {
        SceneManager.LoadScene("start");
    }
}
