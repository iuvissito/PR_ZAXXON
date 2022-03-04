using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class initGame : MonoBehaviour
{
    public float velDino;
    public bool alive;
    public int punt;
    public float score;
    public float distanciarecorrida;
    instanciador ins;
    [SerializeField] Text scoreText;
    [SerializeField] Text tiempotrans;
    float tiempo;
    //float instantiatePos;
    //[SerializeField] AudioClip choqueAudio;
    [SerializeField] AudioClip explosion;
    AudioSource naveAudioSource;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ins = GameObject.Find("instanziador").GetComponent<instanciador>();
        velDino = 15f;

         alive = true;
        punt = 0;
        score = 0;
        //instantiatePos =transform.position;
        tiempo = Time.time;
         scoreText.text =  "SCORE :" + punt +"pts" ;
         naveAudioSource = GetComponent<AudioSource>();
         //queda volumen
    }

    // Update is called once per frame
    void Update()
    { if (alive)
        {
            transform.Translate(Vector3.back * Time.deltaTime * velDino);
            float tiempo = Time.timeSinceLevelLoad;
             //tiempo = Time.time;
            //distanciarecorrida = transform.position - instantiatePos;
             //score = Mathf.Round(tiempo) * velDino + punt;
             //scoreText.text = "SCORE :"+ Mathf.Round(score) + "pts";
             //tiempotrans = tiempo +"seg";
             score = Mathf.Round(tiempo) * velDino + punt;
             scoreText.text = "SCORE :"+ Mathf.Round(score) + "pts";
        tiempotrans.text =  "Tiempo :" +Mathf.Round(tiempo) +"seg";
        
        }
        

    }
    
    public void Morir()
    {
        velDino = 0f;
        alive = false;
        GameObject.Find("dragon").SetActive(false);
        ins.SendMessage("paradcorrutina");
        print("me morrido");
        //naveAudioSource.PlayOneShot(choqueAudio, 1f);
        
        Invoke("GameOver",2f);
        naveAudioSource.PlayOneShot(explosion, 0.5f);

    }
     public void IncrementoPuntuacion()
    {
        punt++;
        
        print( "tiemes : " + punt);
        print (tiempo);
         

    }

    public void Saludar()
    {
        print("Hola mundo");
    }
    public void GameOver()
    {
        SceneManager.LoadScene(3);
    }
}
