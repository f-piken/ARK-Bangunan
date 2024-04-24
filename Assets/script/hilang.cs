using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hilang : MonoBehaviour
{
    public GameObject objectToHide;
    public KeyCode hideKey = KeyCode.H;

    private void Update()
    {
        if (Input.GetKeyDown(hideKey))
        {
            objectToHide.SetActive(false);
        }
    }
}
