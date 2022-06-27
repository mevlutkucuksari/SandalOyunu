using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sandal : MonoBehaviour
{
    public float sandalHiz;
    public TextMeshProUGUI skor;
    int odunParcaSayisi = 0;
    public float zamanHizlandirici = 0.02f;
    public float zamanartti = 0;
    public GameObject resumepanel;
    public GameObject deadpanel;
    public AudioSource seskaynak;
    public AudioClip puan;




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="odun")
        {
            odunParcaSayisi++;
            seskaynak.PlayOneShot(puan);
            skor.text = odunParcaSayisi.ToString();
            float rast = Random.Range(-3.10f, 2.30f);
            zamanartti +=zamanHizlandirici;
            Time.timeScale += zamanartti;
            Debug.Log(Time.timeScale);
            if (Time.timeScale>=3.0f)
            {
                Time.timeScale = 3.0f;

            }
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "engel")
        {
            deadpanel.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        transform.Translate(yatay * sandalHiz * Time.deltaTime, 0, 0);
        if (transform.position.x < -3.6f)
        {
            transform.position = new Vector3(-3.6f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 3.1f)
        {
            transform.position = new Vector3(3.1f, transform.position.y, transform.position.z);
        }

    }
    public void resumeButonu()
    {
        Time.timeScale = 1;
        resumepanel.SetActive(false);
    }
    
}
