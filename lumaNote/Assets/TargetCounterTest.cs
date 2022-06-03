using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCounterTest : MonoBehaviour
{
    public int counter;
    public int prevKeyInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void setPrevKeyInt(int keyInt)
    {
        this.prevKeyInt = keyInt;
    }

    public void UpdateCounter()
    {
        counter++;
    }
}
