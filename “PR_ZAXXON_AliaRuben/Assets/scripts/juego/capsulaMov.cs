using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulaMov : MonoBehaviour
{
    float speed;
    GameObject objectInit;
    initGame initGame;

    // Start is called before the first frame update
    void Start()
    {
        objectInit = GameObject.Find("initGame");
        initGame = objectInit.GetComponent<initGame>();
        speed = initGame.velDino;


    }

    // Update is called once per frame
    void Update()
    {
        speed = initGame.velDino;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        float posZ = transform.position.z;
        //print(posZ);
        if (posZ < -20)
        {
            Destroy(gameObject);
        }
    }
}
