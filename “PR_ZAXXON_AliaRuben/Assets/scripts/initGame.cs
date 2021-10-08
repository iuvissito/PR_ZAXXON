using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initGame : MonoBehaviour
{
   public float velDino;
    // Start is called before the first frame update
    void Start()
    {
        velDino = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * velDino);
    }
}
