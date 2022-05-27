using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTest : MonoBehaviour
{

    public PlayerController player;
    public Transform trans;
    public bool start = false;
    public float elapsedTime;
    public float startX = 0f;
    public float endX = 0f;
    public float rate = 0f;

    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        if(player.moveLeft && !start)
        {
            start = true;
            startX = trans.position.x;
        }

        if (start)
        {
            elapsedTime += Time.deltaTime;
        }

        if (start && !player.moveLeft)
        {
            start = false;
            endX = trans.position.x;
            
            rate = (endX - startX) / elapsedTime;
            startX = endX;
            endX = 0;
            elapsedTime = 0;
        }


    }

    
}
