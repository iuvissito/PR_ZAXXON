using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RETRY : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text ThroneText;
    initGame init;

    private void Start()
    {
       


    }
    public void IniciarJuego()
    {
        
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
