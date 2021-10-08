using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMov : MonoBehaviour
{

   public float Speed;
    public float RtSpeed;
    float limitH;
    // Start is called before the first frame update
    
    void Start()
    {
        Speed = 2f;
        RtSpeed = 10f;
        limitH =  1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        float desplazamientoX = Input.GetAxis("Horizontal");
        float despY = Input.GetAxis("Vertical");
        float despZ = Input.GetAxis("Profundidad");
      
   
       // transform.Translate(Vector3.right * Time.deltaTime * Speed *desplazamientoX,Space.World);
        transform.Translate(Vector3.up * Time.deltaTime * RtSpeed * despY,Space.World);
        transform.Translate(Vector3.back * Time.deltaTime * Speed * despZ);

        float despR = Input.GetAxis("Rotation");
        transform.Rotate(0f, 0f, despR * Time.deltaTime * RtSpeed);

        float PosX = transform.position.x;
        if((PosX < limitH || desplazamientoX < 0f)&&(PosX > -limitH || desplazamientoX  > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed * desplazamientoX, Space.World);

        }
       
    }
}
