using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokedici : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="odun")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag=="engel")
        {
            Destroy(collision.gameObject);
        }
    }
}
