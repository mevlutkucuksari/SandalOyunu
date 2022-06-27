using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
    public void OyunSahnesi()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void OyundanCik()
    {
        Application.Quit();
    }
    
}
