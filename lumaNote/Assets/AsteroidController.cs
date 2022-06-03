using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{

    public SpriteRenderer keyIcon;
    public string key;
    public int keyInt;
    public TargetCounterTest counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.Find("Counter").GetComponent<TargetCounterTest>();
        //GenerateKey();

        GenerateKeyTest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateKeyTest()
    {
        if(counter.prevKeyInt == 0)
        {
            key = "S";
            keyInt = 1;
        }
        else if(counter.prevKeyInt == 3)
        {
            key = "D";
            keyInt = 2;
        }
        else
        {
            int rand = Random.Range(0, 2);
            if(rand == 0)
            {
                keyInt = counter.prevKeyInt - 1;
            }
            else
            {
                keyInt = counter.prevKeyInt + 1;
            }
        }

        counter.setPrevKeyInt(keyInt);
        assignKey();

    }




    /*
    void GenerateKeyTest()
    {
        keyInt = counter.counter % 8;
        if(keyInt > 3)
        {
            keyInt -= 8;
            keyInt = Mathf.Abs(keyInt);
        }
        if (keyInt == 0)
        {
            //A-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/a-key");
            key = "A";
            keyInt = 0;
        }
        else if (keyInt == 1)
        {
            //S-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/s-key");
            key = "S";
            keyInt = 1;
        }
        else if (keyInt == 2)
        {
            //D-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/d-key");
            key = "D";
            keyInt = 2;
        }
        else if (keyInt == 3)
        {
            //F-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/f-key");
            key = "F";
            keyInt = 3;
        }
        counter.UpdateCounter();
    }
    */

    void assignKey()
    {
        if (keyInt == 0)
        {
            //A-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/a-key");
            key = "A";
            keyInt = 0;
        }
        else if (keyInt == 1)
        {
            //S-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/s-key");
            key = "S";
            keyInt = 1;
        }
        else if (keyInt == 2)
        {
            //D-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/d-key");
            key = "D";
            keyInt = 2;
        }
        else if (keyInt == 3)
        {
            //F-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/f-key");
            key = "F";
            keyInt = 3;
        }
    }

    void GenerateKey()
    {
        int rand = Random.Range(1, 4);
        if(rand == 0)
        {
            //A-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/a-key");
            key = "A";
            keyInt = 0;
        }
        else if(rand == 1)
        {
            //S-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/s-key");
            key = "S";
            keyInt = 1;
        }
        else if(rand == 2)
        {
            //D-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/d-key");
            key = "D";
            keyInt = 2;
        }
        else if(rand == 3)
        {
            //F-Key
            keyIcon.sprite = Resources.Load<Sprite>("Keys/f-key");
            key = "F";
            keyInt = 3;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        bool[] conditions = new bool[4];
        conditions[0] = (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.A));
        conditions[1] = (Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.S));
        conditions[2] = (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.D));
        conditions[3] = (Input.GetKey(KeyCode.F) || Input.GetKeyDown(KeyCode.F));

        if(conditions[keyInt])
        {
            Destroy(gameObject);
        }



        /*
        if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.A))
            Destroy(gameObject);
        */

    }
}
