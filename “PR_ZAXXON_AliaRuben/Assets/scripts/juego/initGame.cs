using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initGame : MonoBehaviour
{
    public float velDino;
    public bool alive;
    public int punt;
    instanciador ins;
    // Start is called before the first frame update
    void Start()
    {
        ins = GameObject.Find("instanziador").GetComponent<instanciador>();
        velDino = 15f;
         alive = true;
        punt = 0;
         
         //queda volumen
    }

    // Update is called once per frame
    void Update()
    { if (alive)
        {
            transform.Translate(Vector3.back * Time.deltaTime * velDino);
        }
        

    }
    
    public void Morir()
    {
        velDino = 0f;
        alive = false;
        GameObject.Find("dragon").SetActive(false);
        ins.SendMessage("paradcorrutina");
        print("me morrido");
        Invoke("GameOver",2f);

    }
     public void IncrementoPuntuacion()
    {
        punt++;
        print( "tiemes : " + punt);

    }

    public void Saludar()
    {
        print("Hola mundo");
    }
    public void GameOver()
    {
        SceneManager.LoadScene(3);
    }
}
