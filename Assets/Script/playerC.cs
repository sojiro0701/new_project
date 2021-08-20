using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerC : MonoBehaviour
{
    float speed = 2.0f;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject player;
    public GameObject[] warps = new GameObject [10];
    public GameObject[] warp = new GameObject[10];
    public GameObject text;
    public float rotateSpeed = 3.0f;
    public static bool change;


    // Start is called before the first frame update
    void Start()
    {
        Camera2.SetActive(false);
        Camera3.SetActive(true);
        change = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (timer.isTimeup == false)
        {
            if (change == true)
            {
                GetComponent<Renderer>().material.color = Color.red;
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, speed - 0.5f);
                    gameObject.transform.position += velocity * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, -speed - 0.5f);
                    gameObject.transform.position += velocity * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.RotateAround(player.transform.position, new Vector3(0, 1, 0), rotateSpeed);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.RotateAround(player.transform.position, new Vector3(0, -1, 0), rotateSpeed);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, speed);
                    gameObject.transform.position += velocity * Time.deltaTime;
                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (jump.jumpup == true)
                    {
                        GetComponent<Rigidbody>().velocity = new Vector3(0, 3, 0);
                        jump.jumpup = false;
                    }
                }
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Camera2.SetActive(true);
                    Camera3.SetActive(false);
                }
                if (Input.GetKeyUp(KeyCode.Z))
                {
                    Camera2.SetActive(false);
                    Camera3.SetActive(true);
                }
            }

            if (change == false)
            {
                GetComponent<Renderer>().material.color = Color.blue;
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, speed - 0.5f);
                    gameObject.transform.position += velocity * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, -speed - 0.5f);
                    gameObject.transform.position += velocity * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.RotateAround(player.transform.position, new Vector3(0, 1, 0), rotateSpeed);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.RotateAround(player.transform.position, new Vector3(0, -1, 0), rotateSpeed);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, speed);
                    gameObject.transform.position += velocity * Time.deltaTime;
                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (jump.jumpup == true)
                    {
                        GetComponent<Rigidbody>().velocity = new Vector3(0, 3, 0);
                        jump.jumpup = false;
                    }
                }
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Camera2.SetActive(true);
                    Camera3.SetActive(false);
                }
                if (Input.GetKeyUp(KeyCode.Z))
                {
                    Camera2.SetActive(false);
                    Camera3.SetActive(true);
                }
            }
        }
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floer")
        {
            jump.jumpup = true;
        }
        if (collision.gameObject.tag == "enemy")
        {
            change = false;
        }
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
    }
}
