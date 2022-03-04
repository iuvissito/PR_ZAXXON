using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaderscript : MonoBehaviour
{
    
    [SerializeField] Material material;
    float speed;
    GameObject objectInit;
    initGame initGame;
    // Start is called before the first frame update
    void Start()
    {
         objectInit = GameObject.Find("initGame");
        initGame = objectInit.GetComponent<initGame>();
        material.SetFloat("Vector1_b8453ce02cd44987a8ed96fd2a1a40e4", initGame.velDino);
    }

    // Update is called once per frame
    void Update()
    {
        material.SetFloat("Vector1_b8453ce02cd44987a8ed96fd2a1a40e4", initGame.velDino);
    }
}
