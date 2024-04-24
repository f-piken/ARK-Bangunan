using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void maen()
    {
        song hapus = FindObjectOfType<song>();
        hapus.pidio();
        SceneManager.LoadScene("menu");
    }
    public void info()
    {
        SceneManager.LoadScene("info");
    }
    public void keluar()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }
}
