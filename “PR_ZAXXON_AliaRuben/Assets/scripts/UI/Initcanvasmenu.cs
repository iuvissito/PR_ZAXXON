using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Initcanvasmenu : MonoBehaviour
{
    [SerializeField] Text volumenText;
    float volumen;
    [SerializeField] Slider mySlider;
    // Start is called before the first frame update
    void Start()
    {
        volumenText.text = "Volumen:" + mySlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        
        SceneManager.LoadScene(1);
    }


    public void SubirVolumen()
    {
        volumen = (mySlider.value);
        volumenText.text = "Volumen:" + volumen;
    }
   
}
 
