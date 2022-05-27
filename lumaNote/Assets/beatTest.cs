using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beatTest : MonoBehaviour
{
    // Start is called before the first frame update
    public float currentBeat = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Transform>().position.y >= 1.9)
        {
            currentBeat += 1;
            print("beat" + currentBeat);
        }

        if (this.GetComponent<Transform>().position.y <= -1.9)
        {
            currentBeat += 1;
            print("beat" + currentBeat);
        }

    }
}
