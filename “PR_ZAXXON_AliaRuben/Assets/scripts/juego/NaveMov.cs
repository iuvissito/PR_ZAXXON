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
    initGame initGame;
    
    // Start is called before the first frame update

    void Start()
    {
        initGame = GameObject.Find("initGame").GetComponent<initGame>();
        Speed = 5f;
        RtSpeed = 10f;
        limitH = 10f;
        limitV = 10f;
        limiteSuelo = 0.5f;
        limitZ = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if(initGame.alive)
        {
            MoverNave();
        }
    }

    void MoverNave()
    {

        float desplazamientoX = Input.GetAxis("Horizontal");
        float despY = Input.GetAxis("Vertical");
        float despZ = Input.GetAxis("Profundidad");


        // transform.Translate(Vector3.right * Time.deltaTime * Speed *desplazamientoX,Space.World);
        // transform.Translate(Vector3.up * Time.deltaTime * RtSpeed * despY,Space.World);
        //transform.Translate(Vector3.back * Time.deltaTime * Speed * despZ);

        float despR = Input.GetAxis("Rotation");


        float PosX = transform.position.x;
        if ((PosX < limitH || desplazamientoX < 0f) && (PosX > -limitH || desplazamientoX > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed * desplazamientoX, Space.World);

        }
        float posY = transform.position.y;
        if ((posY < limitV || despY < 0f) && (posY > limiteSuelo || despY > 0f))
        {
            transform.Translate(Vector3.up * Time.deltaTime * Speed * despY, Space.World);

        }
        float posZ = transform.position.z;

        if ((posZ < limitZ || despZ < 0f) && (posZ > -limitZ || despZ > 0f))
        {

            transform.Translate(Vector3.forward * Time.deltaTime * Speed * despZ, Space.World);

            // controles invertidos porque lo quiero asi para mayor dificultad
        }
        transform.Rotate(0f, 0f, despR * Time.deltaTime * RtSpeed * -RtSpeed);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            initGame.SendMessage("Morir");
          
        }
         if(other.gameObject.layer == 7)
         {
            initGame.SendMessage("IncrementoPuntuacion");
          
        }   
          

    }
    
}



