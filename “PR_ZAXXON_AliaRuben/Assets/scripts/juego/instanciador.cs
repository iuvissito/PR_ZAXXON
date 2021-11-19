using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour
   
{
    float intervalo;
    [SerializeField] GameObject capsula;
    [SerializeField] Transform instantiatePos;

    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.5f;

        StartCoroutine("CrearCapsula");
        StartCoroutine("CrearCapsula");
        StartCoroutine("CrearCapsula");
        StartCoroutine("CrearCapsula");
        StartCoroutine("CrearCapsula");
        StartCoroutine("CrearCapsula");
        StartCoroutine("CrearCapsula");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CrearCapsula()
    {
        while (true)
        {
            
            float randomX = Random.Range(-10f, 10f);
            float randomY = Random.Range(0f, 10f);
            Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);
            Instantiate(capsula, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }
    }
}
