using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;

    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        if (player.gameover == false)
        {
            InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        float positionx = Random.Range(-8, 8);
        float positionz = Random.Range(-5, 5);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], new Vector3(positionx, 0, positionz), animalPrefabs[animalIndex].transform.rotation);
    }
}
