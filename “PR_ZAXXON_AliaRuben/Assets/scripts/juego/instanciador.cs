using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour

{
    float intervalo;
    [SerializeField] GameObject capsula;
    [SerializeField] GameObject power;
    [SerializeField] Transform instantiatePos;

    initGame init;



    // Start is called before the first frame update
    void Start()
    {
        init = GameObject.Find("initGame").GetComponent<initGame>();
        if (init.alive)
        {
            intervalo = 0.5f;

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
            for(int n = 0; n < 7; n++)
            {
                float randomX = Random.Range(-1.5f, 1.5f);
                float randomY = Random.Range(0f, 1.28f);
                Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);
                Instantiate(capsula, newPos, Quaternion.identity);

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
