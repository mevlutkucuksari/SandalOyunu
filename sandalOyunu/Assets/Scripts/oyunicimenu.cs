using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunicimenu : MonoBehaviour
{
    sandal sandal;
    public GameObject resumepanel;
    private void Start()
    {
        sandal = GetComponent<sandal>();
    }
    public void baslangicEkrani()
    {
        SceneManager.LoadScene(0);
    }
    public void oyundanCik()
    {
        Application.Quit();
    }
    
    public void paneliacma()
    {
        Time.timeScale = 0;
        resumepanel.SetActive(true);

    }
    public void yenidenoyna()
    {
        SceneManager.LoadScene(1);
        resumepanel.SetActive(false);
        Time.timeScale = 1;
    }
}
