
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMov : MonoBehaviour
{

    [SerializeField] float Speed;
    [SerializeField] float RtSpeed;
    float limitH;
    float limitV;
    float limiteSuelo;
    float limitZ;
    initGame initGameScript;
    
    // Start is called before the first frame update

    void Start()
    {

        initGameScript = GameObject.Find("initGame").GetComponent<initGame>();
        initGameScript.SendMessage("Saludar");
        Speed = 5f;
        RtSpeed = 10f;
        limitH = 5f;
        limitV = 1.28f;
        limiteSuelo = 0.06f;
        limitZ = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(initGameScript.alive)
        {
            MoverNave();
        }
        
        //print(initGameScript.alive);
    }

    void MoverNave()
    {
        //print(transform.position);
        float desplazamientoX = Input.GetAxis("Horizontal");
        float despY = Input.GetAxis("Vertical");
        float despZ = Input.GetAxis("Profundidad");


        // transform.Translate(Vector3.right * Time.deltaTime * Speed *desplazamientoX,Space.World);
        // transform.Translate(Vector3.up * Time.deltaTime * RtSpeed * despY,Space.World);
        //transform.Translate(Vector3.back * Time.deltaTime * Speed * despZ);

        float despR = Input.GetAxis("Rotation");


        float PosX = transform.position.x;
       // print(limitH + " - " + PosX);
        if ((PosX < limitH || desplazamientoX < 0f) && (PosX > -limitH || desplazamientoX > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed * desplazamientoX, Space.World);

        }
        float posY = transform.position.y;
        //print(limitV + " - " + posY);
        if ((posY < limitV || despY < 0f) && (posY > limiteSuelo || despY > 0f))
        {
           transform.Translate(Vector3.up * Time.deltaTime * Speed * despY, Space.World);

        }
        float posZ = transform.position.z;
        //print(limitZ + " - " + posZ);
        if ((posZ < limitZ || despZ < 0f) && (posZ > -limitZ || despZ > 0f))
        {

            transform.Translate(Vector3.forward * Time.deltaTime * Speed * despZ, Space.World);

            // controles invertidos porque lo quiero asi para mayor dificultad
        }
        transform.Rotate(0f, 0f, despR * Time.deltaTime * RtSpeed * -RtSpeed);

    }
    private void OnTriggerEnter(Collider other)
    {
        
        
       // print(other.gameObject.name);
        if(other.gameObject.layer == 6)
        {
           
            initGameScript.SendMessage("Morir");


          
        }
         if(other.gameObject.layer == 7)
         {
            initGameScript.SendMessage("IncrementoPuntuacion");
          
        } 
        


    }
    
}



