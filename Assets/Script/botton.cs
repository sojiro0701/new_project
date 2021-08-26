using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickstartbutton()
    {
        SceneManager.LoadScene("home");
    }
    public void OnClickendbotton()
    {
        SceneManager.LoadScene("home");
    }
    public void OnClickgamestaertbotton()
    {
        SceneManager.LoadScene("soto");
    }
    public void OnClickoperationmethods()
    {
        SceneManager.LoadScene("description");
    }
    public void OnClickhome()
    {
        SceneManager.LoadScene("home");
    }

}
