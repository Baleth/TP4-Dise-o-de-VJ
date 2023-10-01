using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    // Start is called before the first frame update
    CameraFace cameraFace;
    float speed = 1.0f;
    private float lastY;
    Vector3 inicial;
    private void Awake()
    {
        cameraFace = (CameraFace)FindObjectOfType(typeof(CameraFace));
        //lastY = cameraFace.ejey;
        inicial = transform.position;
    }
    void Start()
    {
       // Debug.Log("el primer valor es: " + (cameraFace.primerY - cameraFace.ejey));
        Debug.Log("el primer valor es: " + (cameraFace.primerX - cameraFace.ejex));

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        
       //  float norm = Mathf.Clamp(cameraFace.primerY - cameraFace.ejey, -1, 1);
        float norm =  Mathf.Clamp(cameraFace.primerX - cameraFace.ejex, -20, 20);
        Debug.Log("norm: "+norm);
        //Debug.Log("eje y: "+cameraFace.ejey);
        //Debug.Log("resta: "+ (cameraFace.ejey - lastY));
        
        
     //   transform.position = Vector3.MoveTowards(transform.position, new Vector3(inicial.x,inicial.y+norm, inicial.z),step * 3);

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(inicial.x+norm, inicial.y, inicial.z), step * 20);
    }
}
