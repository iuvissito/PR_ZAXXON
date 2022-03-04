using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initmenu : MonoBehaviour
{
    public void MenuInicial()
    {
        SceneManager.LoadScene(0);
    }
    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }
    public void Config()
    {
        SceneManager.LoadScene(2);
    }
    public void  IniciarTrhone()
    {
        SceneManager.LoadScene(4);
    }
    
}
