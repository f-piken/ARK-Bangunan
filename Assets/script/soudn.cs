using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class soudn : MonoBehaviour
{
    public GameObject tombol1;
    public GameObject tombol2;
    private void kondisi()
    {
        song Kondisi = FindObjectOfType<song>();
        if (Kondisi.lagu == null)
        {
            tombol1.SetActive(false);
        }
        else if (Kondisi.lagu != null)
        {
            tombol2.SetActive(false);
        }
    }
}
