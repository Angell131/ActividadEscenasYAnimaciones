using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad=5f;
    public float rotacion=50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput=Input.GetAxis("Horizontal");
        float verticalInput=Input.GetAxis("Vertical");
        Vector3 direccion=new Vector3(horizontalInput,0,verticalInput);
        direccion.Normalize();
        transform.position=transform.position+direccion*velocidad*Time.deltaTime;
        if(direccion!=Vector3.zero) transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(direccion),rotacion*Time.deltaTime);
    }
}
