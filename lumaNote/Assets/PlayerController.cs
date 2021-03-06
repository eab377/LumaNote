using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    public Rigidbody playerRigidbody;
    public Transform playerTransform;
    public bool moveLeft;
    public bool cursorControl = false;
    public int sensitivity = 1;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
        playerTransform = this.GetComponent<Transform>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if(cursorControl)
        {
            Vector3 mousePos3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);
            float mousePosX = Camera.main.ScreenToWorldPoint(mousePos3).x;
            //print(mousePosX);
            //playerTransform.position += Vector3.ClampMagnitude(new Vector3(Input.mousePosition.x * sensitivity, 0, 0), 2);
            //playerTransform.position += Vector3.ClampMagnitude(new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x * sensitivity, 0, 0), 2
            //playerTransform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            playerTransform.position = new Vector3(mousePosX, playerTransform.position.y, playerTransform.position.z);
        }

        bool moveLeft = (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A));
        this.moveLeft = moveLeft;
        bool moveRight = (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D));
        /*
        if (moveLeft ^ moveRight)
        {
            if (moveLeft)
            {
                playerTransform.position = playerTransform.position - (new Vector3(speed * Time.deltaTime, 0, 0));
                //playerRigidbody.AddForce(new Vector3(1 * speed, 0, 0));
            }

            if (moveRight)
            {
                playerTransform.position = playerTransform.position + (new Vector3(speed * Time.deltaTime, 0, 0));
                //playerRigidbody.AddForce(new Vector3(-1 * speed, 0, 0));
            }
        }
        */
    }
}
