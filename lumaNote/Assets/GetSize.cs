using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(this.GetComponent<MeshFilter>().mesh.bounds.size.z);       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
