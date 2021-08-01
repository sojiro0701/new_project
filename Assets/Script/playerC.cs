using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerC : MonoBehaviour
{
    float speed = 2.0f;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject player;
    public GameObject warp1;
    public GameObject warps1;
    public GameObject warp2;
    public GameObject warps2;
    public GameObject warp3;
    public GameObject warps3;
    public GameObject warp4;
    public GameObject warps4;
    public GameObject text;
    public float rotateSpeed = 3.0f;
    public static bool change;


    // Start is called before the first frame update
    void Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
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
                if (Input.GetKey(KeyCode.Z))
                {
                    Camera1.SetActive(false);
                    Camera2.SetActive(true);
                    Camera3.SetActive(false);
                }
                if (Input.GetKey(KeyCode.X))
                {
                    Camera1.SetActive(false);
                    Camera2.SetActive(false);
                    Camera3.SetActive(true);
                }
                if (Input.GetKey(KeyCode.C))
                {
                    Camera1.SetActive(true);
                    Camera2.SetActive(false);
                    Camera3.SetActive(false);
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
                if (Input.GetKey(KeyCode.Z))
                {
                    Camera1.SetActive(false);
                    Camera2.SetActive(true);
                    Camera3.SetActive(false);
                }
                if (Input.GetKey(KeyCode.X))
                {
                    Camera1.SetActive(false);
                    Camera2.SetActive(false);
                    Camera3.SetActive(true);
                }
                if (Input.GetKey(KeyCode.C))
                {
                    Camera1.SetActive(true);
                    Camera2.SetActive(false);
                    Camera3.SetActive(false);
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
        if (collision.gameObject == warp1)
        {
            transform.position = warps2.transform.position;
        }
        if (collision.gameObject == warp2)
        {
            transform.position = warps1.transform.position;
        }
        if (collision.gameObject == warp3)
        {
            transform.position = warps4.transform.position;
        }
        if (collision.gameObject == warp4)
        {
            transform.position = warps3.transform.position;
        }
    }
}
