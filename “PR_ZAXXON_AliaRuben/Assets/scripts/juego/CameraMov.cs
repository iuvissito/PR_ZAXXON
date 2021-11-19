using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    [SerializeField] Transform navePosition;
    [SerializeField] float smoothVelocity = 0.1F;
    [SerializeField] Vector3 speedCamera = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(navePosition.transform.position.x, navePosition.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref speedCamera, smoothVelocity);

    }
}
