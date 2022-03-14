using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : Fruit
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,10);
    }
    public override void addscore()
    {
        score += 10;
        Debug.Log("score is " + score);
    }

    private void OnTriggerEnter(Collider other)
    {
        addscore();
        Destroy(gameObject);
    }
}
