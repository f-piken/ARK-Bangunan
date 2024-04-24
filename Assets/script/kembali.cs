using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kembali : MonoBehaviour
{
    public void camera_balek()
    {
        song Music = FindObjectOfType<song>();
        if(Music.tmbl.activeSelf)
        {
        Music.muncul1();
        }
        SceneManager.LoadScene("menu");
    }    
    public void balek()
    {
        SceneManager.LoadScene("menu");
    }
}
