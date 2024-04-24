using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void ar()
    {
        song Music = FindObjectOfType<song>();
        Music.hilang1();
        Music.hilang2();
        SceneManager.LoadScene("AR");
    }
    public void marker()
    {
        SceneManager.LoadScene("marker");
    }
    public void petunjuk()
    {
        SceneManager.LoadScene("petunjuk");
    }
    public void luar()
    {
        song Music = FindObjectOfType<song>();
        Music.muncul2();
        SceneManager.LoadScene("awal");
    }
}
