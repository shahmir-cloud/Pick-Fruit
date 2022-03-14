using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : Fruit
{
    public bool gameover=false;
    private Rigidbody playerRb;
    public float speed = 5.0f;
    public Image image;
    public Text Textscore;

    //Apple apple;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //apple = GameObject.FindGameObjectWithTag("apple").GetComponent<Apple>();

    }

    // Update is called once per frame
    void Update()
    {
        Textscore.text = "Score : " + score.ToString();

        if (gameover == false)
        {
            float forwardInput = Input.GetAxis("Vertical");
            float HorizontalInput = Input.GetAxis("Horizontal");
            playerRb.AddForce(Vector3.forward * speed * forwardInput);
            playerRb.AddForce(Vector3.right * speed * HorizontalInput);
        }
        else
        {
            image.gameObject.SetActive(true);
        }
        buundries();
    }

    void buundries()
    {
        if (transform.position.x < -8)
        {
            transform.position = new Vector3(-8, transform.position.y, transform.position.z);

        }
        if (transform.position.x > 8)
        {
            transform.position = new Vector3(8, transform.position.y, transform.position.z);
        }
        if (transform.position.z > 5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 5);
        }
        if (transform.position.z < -5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -5);
        }
    }
}
