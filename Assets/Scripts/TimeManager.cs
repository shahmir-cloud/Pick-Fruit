using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private float time = 60;
    public Text Texttime;

    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        Texttime.text = "Time " + time.ToString();
        if (time < 0)
        {
            player.gameover = true;
        }
        if (player.gameover == false)
        {
            time -= Time.deltaTime;

        }

        

    }
}
