using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class klick : MonoBehaviour
{
    public GameObject tombol1;
    public GameObject tombol2;
    public void mulai()
    {
        song Music = FindObjectOfType<song>();
        Music.muncul1();
        tombol1.SetActive(false);
        tombol2.SetActive(true);
    }

    public void berhenti()
    {
        song Music = FindObjectOfType<song>();
        Music.hilang1();
        tombol2.SetActive(false);
        tombol1.SetActive(true);
    }
    
}