using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] spawnerNesneleri;
    void Start()
    {
        InvokeRepeating("spawnerEtmeZamani", 0.0f, 5.0f);
        
    }

    void spawnerEtmeZamani()
    {
        int rast = Random.Range(0, spawnerNesneleri.Length);
        
        GameObject a= Instantiate(spawnerNesneleri[rast]);
        float rastgele = Random.Range(-3.10f, 2.30f);
        a.transform.position= new Vector3(rastgele, 25.0f, 0);
        a.transform.Translate(Vector3.down * Time.deltaTime);


    }
}
