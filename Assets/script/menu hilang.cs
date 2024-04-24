using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuhilang : MonoBehaviour
{
    public void hilang()
    {
        gameObject.SetActive(false);
    }
    public void muncul()
    {
        gameObject.SetActive(true);
    }
    public void hapus()
    {
        Destroy(gameObject);
    }
}
