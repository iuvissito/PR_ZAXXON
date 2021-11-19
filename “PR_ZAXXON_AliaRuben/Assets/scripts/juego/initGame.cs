using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initGame : MonoBehaviour
{
    public float velDino;
    public bool alive;
    public int punt;
    // Start is called before the first frame update
    void Start()
    {
        velDino = 20f;
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
       GameObject.Find("nave").SetActive(false);
    }
     public void IncrementoPuntuacion()
    {
        punt++;
        print( "tiemes : " + punt);
        
    }
}
