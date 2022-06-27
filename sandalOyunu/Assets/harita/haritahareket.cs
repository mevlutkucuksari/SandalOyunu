using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haritahareket : MonoBehaviour
{
    public float Hiz;
    Vector3 ilkpozisyonu;
    void Start()
    {
        ilkpozisyonu = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Hiz * Time.deltaTime);
        if (transform.position.y< -20.26f)
        {
            transform.position = ilkpozisyonu;
        }
    }
}
