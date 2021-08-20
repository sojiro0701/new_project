﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class enemyS : MonoBehaviour
{
    public Transform target;
    public Transform point;
    public　GameObject[] points = new GameObject[13];
    public GameObject[] warps = new GameObject[2];
    public int taregetIndex;
    public float speed = 2;
    NavMeshAgent agent;
    public GameObject warp1;
    public GameObject warp2;
    public float timeleft;
    bool run;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        taregetIndex = Random.Range(0, 12);
        Debug.Log(taregetIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.isTimeup == false)
        {
            if (playerC.change == true)
            {
                if (run == true)
                {
                    speed = 3.0f;
                    agent.SetDestination(target.position);
                }
                else
                {
                    Debug.Log("OK");
                    agent.SetDestination(points[taregetIndex].transform.position);
                    if (Vector3.Distance(transform.position, points[taregetIndex].transform.position) < 2.0f)
                    {
                        //points = GameObject.FindGameObjectsWithTag("point");

                        Debug.Log("A");
                        taregetIndex = Random.Range(0, 43);
                        transform.LookAt(points[taregetIndex].transform.position);

                        Debug.Log(taregetIndex);
                    }
                    if (agent.isOnOffMeshLink)
                    {
                        Debug.Log("OP");
                        //agent.CompleteOffMeshLink();
                        GetComponent<Renderer>().enabled = false;
                        agent.speed = 5.0f;
                        Debug.Log("at" + agent.speed);
                    }
                    else
                    {
                        GetComponent<Renderer>().enabled = true;
                        agent.speed = 2.0f;
                        Debug.Log("agent:"+agent.speed);
                    }
                }
            }
            else
            {
                agent.SetDestination(points[taregetIndex].transform.position);
                if (Vector3.Distance(transform.position, points[taregetIndex].transform.position) < 2.0f)
                {
                    //points = GameObject.FindGameObjectsWithTag("point");

                    Debug.Log("A");
                    taregetIndex = Random.Range(0, 43);
                    transform.LookAt(points[taregetIndex].transform.position);

                    Debug.Log(taregetIndex);
                }
                if (agent.isOnOffMeshLink)
                {
                    GetComponent<Renderer>().enabled = false;
                    agent.speed = 5.0f;
                    
                }
                else
                {
                    GetComponent<Renderer>().enabled = true;
                    agent.speed = 2.0f;
                    
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            run = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            run = false;
        }
    }
    
}
