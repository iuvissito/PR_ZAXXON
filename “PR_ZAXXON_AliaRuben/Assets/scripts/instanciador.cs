using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour
    //script instanciador colmnas
{
    [SerializeField] GameObject capsula;
    [SerializeField] Transform initPost;

    private float  despX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 desPost = initPost.position;
        Vector3 despl = new Vector3( despX , 0, 0);

        for (int n = 0; n < 10; n++) 


        {
            Instantiate(capsula, desPost, Quaternion.identity);

            desPost = desPost + despl;
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
