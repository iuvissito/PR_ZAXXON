using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour

{
    float intervalo;
    //[SerializeField] GameObject  capsula;
    [SerializeField] GameObject[] obstaculo;
    [SerializeField] GameObject power;
    [SerializeField] Transform instantiatePos;

    initGame init;



    // Start is called before the first frame update
    void Start()
    {
        init = GameObject.Find("initGame").GetComponent<initGame>();
        if (init.alive)
        {
            intervalo = 1f;

            StartCoroutine("CrearCapsula");
            /*
            StartCoroutine("CrearCapsula");
            StartCoroutine("CrearCapsula");
            StartCoroutine("CrearCapsula");
            StartCoroutine("CrearCapsula");
            StartCoroutine("CrearCapsula");
            StartCoroutine("CrearCapsula");
            */
            StartCoroutine("Crearpowers");


        }
        /*
        if (init.alive == false)
        {

            StopCoroutine("CrearCapsula");
            StopCoroutine("Crearpowers");
        }
        */
        

    }
    

// Update is called once per frame
void Update()
    {

    }
    public void paradcorrutina()
    {
        StopCoroutine("CrearCapsula");
        StopCoroutine("Crearpowers");
    }

    IEnumerator CrearCapsula()
    {
        while (true)
        {
            for(int n = 0; n < 4; n++)
            {
                float randomX = Random.Range(-5f, 5f);
                float randomY = Random.Range(0f, 1.28f);
                Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);
                Instantiate(obstaculo[n], newPos, Quaternion.identity);

            }

            yield return new WaitForSeconds(intervalo);
        }

        
    }

    IEnumerator Crearpowers()
    {
        while (true)
        {

            float randomX = Random.Range(-4f, 8f);
            float randomY = Random.Range(0f, 6f);
            Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);
            Instantiate(power, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }

    }
}
