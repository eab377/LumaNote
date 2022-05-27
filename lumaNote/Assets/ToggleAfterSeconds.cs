using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAfterSeconds : MonoBehaviour
{
    public GameObject spawner;
    public GameObject player;
    public GameObject music;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(toggle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator toggle()
    {
        yield return new WaitForSeconds(2);
        spawner.active = true;
        player.active = true;
        music.active = true;
    }
}
