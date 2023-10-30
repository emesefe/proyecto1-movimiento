using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //[SerializeField] private GameObject camera;
    
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float lateralSpeed = 5f;

    //[SerializeField] private Vector3 offset = new Vector3(0, 5, -10);
    
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        // La detección de inputs debe ir en el Update
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Recomendación: si trabajamos con direcciones, que sean vectores unitarios
        // Vector3.right se corresponde con (1, 0, 0)
        // Vector3.left se corresponde con (-1, 0, 0)
        // Vector3.up se corresponde con (0, 1, 0)
        // Vector3.down se corresponde con (0, -1, 0)
        // Vector3.forward se corresponde con (0, 0, 1)
        // Vector3.back se corresponde con (0, 0, -1)
        
        // Movimiento en función del sistema de coordenadas local (el del objeto)
        // Movimiento hacia adelante automático
        // transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        // Movimiento hacia adelante afectado por el input del usuario (vertical)
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        
        // Movimiento lateral afectado por el input del usuario (horizontal)
        //transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horizontalInput);
        
        transform.Rotate(Vector3.up, lateralSpeed * Time.deltaTime * horizontalInput);
        
        

        // camera.transform.position = transform.position + offset;
    }
}
