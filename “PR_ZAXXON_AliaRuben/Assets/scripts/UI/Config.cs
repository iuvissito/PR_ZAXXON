using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Config : MonoBehaviour
{
    public static float musicVolume = 50f;
    // Start is called before the first frame update
    void Start()
    {
       
        musicVolume = 50f;
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
