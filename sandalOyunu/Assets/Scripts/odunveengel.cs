using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odunveengel : MonoBehaviour
{
    
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 25.0f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(3*Vector3.down * Time.deltaTime);
    }
}
