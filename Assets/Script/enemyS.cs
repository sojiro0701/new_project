using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class enemyS : MonoBehaviour
{
    public Transform target;
    public Transform point;
    public　GameObject[] points = new GameObject[13];
    public int taregetIndex;
    public float speed = 2;
    NavMeshAgent agent;
    public float timeleft;
    bool run;
    public GameObject[] warp = new GameObject[1];
    public GameObject[] warps = new GameObject[1];
    public static bool player;

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
                        void OnCollisionEnter(Collision collision)
                        {
                            if (collision.gameObject == warp[0])
                            {
                                transform.position = warps[1].transform.position;
                            }
                            if (collision.gameObject == warp[1])
                            {
                                transform.position = warps[0].transform.position;
                            }
                            if (collision.gameObject == warp[2])
                            {
                                transform.position = warps[21].transform.position;
                            }
                            if (collision.gameObject == warp[21])
                            {
                                transform.position = warps[2].transform.position;
                            }
                            if (collision.gameObject == warp[4])
                            {
                                transform.position = warps[9].transform.position;
                            }
                            if (collision.gameObject == warp[5])
                            {
                                transform.position = warps[12].transform.position;
                            }
                            if (collision.gameObject == warp[6])
                            {
                                transform.position = warps[13].transform.position;
                            }
                            if (collision.gameObject == warp[7])
                            {
                                transform.position = warps[8].transform.position;
                            }
                            if (collision.gameObject == warp[8])
                            {
                                transform.position = warps[7].transform.position;
                            }
                            if (collision.gameObject == warp[9])
                            {
                                transform.position = warps[4].transform.position;
                            }
                            if (collision.gameObject == warp[10])
                            {
                                transform.position = warps[11].transform.position;
                            }
                            if (collision.gameObject == warp[11])
                            {
                                transform.position = warps[10].transform.position;
                            }
                            if (collision.gameObject == warp[12])
                            {
                                transform.position = warps[5].transform.position;
                            }
                            if (collision.gameObject == warp[13])
                            {
                                transform.position = warps[6].transform.position;
                            }
                            if (collision.gameObject == warp[15])
                            {
                                transform.position = warps[14].transform.position;
                            }
                            if (collision.gameObject == warp[14])
                            {
                                transform.position = warps[15].transform.position;
                            }
                            if (collision.gameObject == warp[16])
                            {
                                transform.position = warps[17].transform.position;
                            }
                            if (collision.gameObject == warp[17])
                            {
                                transform.position = warps[16].transform.position;
                            }
                            if (collision.gameObject == warp[18])
                            {
                                transform.position = warps[3].transform.position;
                            }
                            if (collision.gameObject == warp[3])
                            {
                                transform.position = warps[18].transform.position;
                            }
                            if (collision.gameObject == warp[25])
                            {
                                transform.position = warps[20].transform.position;
                            }
                            if (collision.gameObject == warp[20])
                            {
                                transform.position = warps[25].transform.position;
                            }
                            if (collision.gameObject == warp[22])
                            {
                                transform.position = warps[19].transform.position;
                            }
                            if (collision.gameObject == warp[19])
                            {
                                transform.position = warps[22].transform.position;
                            }
                            if (collision.gameObject == warp[23])
                            {
                                transform.position = warps[24].transform.position;
                            }
                            if (collision.gameObject == warp[24])
                            {
                                transform.position = warps[23].transform.position;
                            }
                            if (collision.gameObject == warp[26])
                            {
                                transform.position = warps[27].transform.position;
                            }
                            if (collision.gameObject == warp[27])
                            {
                                transform.position = warps[26].transform.position;
                            }
                            if (collision.gameObject == warp[28])
                            {
                                transform.position = warps[29].transform.position;
                            }
                            if (collision.gameObject == warp[29])
                            {
                                transform.position = warps[28].transform.position;
                            }
                            if (collision.gameObject == warp[30])
                            {
                                transform.position = warps[33].transform.position;
                            }
                            if (collision.gameObject == warp[33])
                            {
                                transform.position = warps[30].transform.position;
                            }
                            if (collision.gameObject == warp[31])
                            {
                                transform.position = warps[32].transform.position;
                            }
                            if (collision.gameObject == warp[32])
                            {
                                transform.position = warps[31].transform.position;
                            }
                            if (collision.gameObject == warp[34])
                            {
                                transform.position = warps[35].transform.position;
                            }
                            if (collision.gameObject == warp[35])
                            {
                                transform.position = warps[34].transform.position;
                            }
                            if (collision.gameObject == warp[36])
                            {
                                transform.position = warps[38].transform.position;
                            }
                            if (collision.gameObject == warp[37])
                            {
                                transform.position = warps[39].transform.position;
                            }
                            if (collision.gameObject == warp[38])
                            {
                                transform.position = warps[36].transform.position;
                            }
                            if (collision.gameObject == warp[39])
                            {
                                transform.position = warps[37].transform.position;
                            }
                            if (collision.gameObject == warp[44])
                            {
                                transform.position = warps[40].transform.position;
                            }
                            if (collision.gameObject == warp[40])
                            {
                                transform.position = warps[44].transform.position;
                            }
                            if (collision.gameObject == warp[41])
                            {
                                transform.position = warps[45].transform.position;
                            }
                            if (collision.gameObject == warp[45])
                            {
                                transform.position = warps[41].transform.position;
                            }
                            if (collision.gameObject == warp[42])
                            {
                                transform.position = warps[46].transform.position;
                            }
                            if (collision.gameObject == warp[46])
                            {
                                transform.position = warps[42].transform.position;
                            }
                            if (collision.gameObject == warp[43])
                            {
                                transform.position = warps[47].transform.position;
                            }
                            if (collision.gameObject == warp[47])
                            {
                                transform.position = warps[43].transform.position;
                            }
                            if (collision.gameObject == warp[48])
                            {
                                transform.position = warps[49].transform.position;
                            }
                            if (collision.gameObject == warp[49])
                            {
                                transform.position = warps[48].transform.position;
                            }
                        }
                    
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
