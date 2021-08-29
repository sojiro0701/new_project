using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class playerA : MonoBehaviour
{
    public GameObject[] point = new GameObject[1];
    public GameObject[] warp = new GameObject[1];
    public GameObject[] warps = new GameObject[1];
    public int taregetIndex;
    public float speed;
    NavMeshAgent agent;
    public static bool change1;
    public static bool chaek1;
    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        change1 = true;
        agent = GetComponent<NavMeshAgent>();

        taregetIndex = Random.Range(0, 100);
        Debug.Log(taregetIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.isTimeup == false)
        {
            if (change1 == true)
            {
                if (chaek1 == true)
                {

                }
            }
        }

    }
}
