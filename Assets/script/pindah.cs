using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindah : MonoBehaviour
{
    public string nextSceneName; // Nama scene tujuan

    void Start()
    {
        // Panggil method untuk berpindah scene setelah beberapa detik (misalnya setelah 5 detik)
        Invoke("SwitchScene", 5f);
    }

    void SwitchScene()
    {
        // Memuat scene berikutnya
        SceneManager.LoadScene(nextSceneName);
    }
}
