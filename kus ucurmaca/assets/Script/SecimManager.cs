using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecimManager : MonoBehaviour
{
    public void SariKusButton()
    {
        SceneManager.LoadScene(3);
    }

    public void MaviKusButton()
    {
        SceneManager.LoadScene(5);
    }

    public void KirmiziKusButton()
    {
        SceneManager.LoadScene(4);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(1);
    }
}

