using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class link : MonoBehaviour
{
    public Button button;
    public string linkURL;

    private void Start()
    {
        button.onClick.AddListener(OpenLink);
    }

    public void OpenLink()
    {
        Application.OpenURL(linkURL);
    }
}
