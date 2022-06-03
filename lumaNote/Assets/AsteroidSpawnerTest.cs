using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnerTest : MonoBehaviour
{

    public GameObject asteroid;
    public float elapsedTime;
    public float lastSpawn;
    public Transform spawnPoint;
    public float speed = 5;
    public float nextSpawn = 0.958228f;
    public float numberSpawned = 0;


    //0.958228 size of asteroid (Z)
    //15.18
    //7.59

    // Start is called before the first frame update
    void Start()
    {
        /*
        GameObject ast = Instantiate(asteroid, spawnPoint.position, spawnPoint.rotation);
        ast.transform.SetParent(this.GetComponent<Transform>());
        */
        numberSpawned += 1;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Transform>().position -= new Vector3(0, 0, speed * Time.deltaTime);
        if(this.GetComponent<Transform>().position.z <= nextSpawn)
        {
            nextSpawn -= 15.18f; //prev 15.18
            spawnAsteroid();
        }
    }

    void spawnAsteroid()
    {
        float yPos = -2f;
        /*
        if((numberSpawned / 2) % 2 == 0)
        {
            yPos = 2f;
        }
        else
        {
            yPos = -0.5f;
        }
        if(numberSpawned % 2 == 0)
        {
            GameObject ast = Instantiate(asteroid, new Vector3(spawnPoint.position.x, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
        }
        else if(numberSpawned == 1)
        {
            yPos = 1f;
            GameObject ast = Instantiate(asteroid, new Vector3(spawnPoint.position.x, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
        }
        else if(numberSpawned == 3)
        {
            yPos = 1f;
            GameObject ast = Instantiate(asteroid, new Vector3(spawnPoint.position.x, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
        }
        */
        int rand = Random.Range(0, 3);
        if (rand == 1)
        {
            numberSpawned += 1;
            if (numberSpawned == 8)
            {
                numberSpawned = 0;
            }
            return;
        }
        int xPos = Random.Range(-2, 3);
        if(numberSpawned == 0)
        {
            yPos = 2f;
            GameObject ast = Instantiate(asteroid, new Vector3(xPos, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
        }
        else if(numberSpawned == 1)
        {
            yPos = 1f;
            GameObject ast = Instantiate(asteroid, new Vector3(xPos, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
        }
        else if (numberSpawned == 2)
        {
            
            yPos = -0.5f;
            GameObject ast = Instantiate(asteroid, new Vector3(xPos, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
            
        }
        else if(numberSpawned == 3)
        {
            
            yPos = -1.5f;
            GameObject ast = Instantiate(asteroid, new Vector3(xPos, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
            
        }
        else if (numberSpawned == 4)
        {
            yPos = -2f;
            GameObject ast = Instantiate(asteroid, new Vector3(xPos, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
        }
        else if (numberSpawned == 5)
        {
            
            yPos = -1f;
            GameObject ast = Instantiate(asteroid, new Vector3(xPos, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
            
        }
        else if (numberSpawned == 6)
        {
            
            yPos = 0.5f;
            GameObject ast = Instantiate(asteroid, new Vector3(xPos, yPos, spawnPoint.position.z), spawnPoint.rotation);
            ast.transform.SetParent(this.GetComponent<Transform>());
            
        }


        numberSpawned += 1;
        if(numberSpawned == 8)
        {
            numberSpawned = 0;
        }
    }
}
