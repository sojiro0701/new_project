using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botton : MonoBehaviour
{
    public static bool mode;

    // Start is called before the first frame update
    void Start()
    {
        mode = false;
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
        //bool modeの判定によってgame modeを帰れるようにif分で制御
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
    public void OnClickMoide()
    {
        SceneManager.LoadScene("Mode");
    }
    public void OnClickCatchAndCatch()
    {
        mode = false;
    }
    public void OnClickCopsandRobbers()
    {
        mode = true;
    }

}
