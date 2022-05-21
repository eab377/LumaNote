using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public Transform asteroidsTransform;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        asteroidsTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        asteroidsTransform.position -= (new Vector3(0, 0, (speed * Time.deltaTime)));
    }
}
