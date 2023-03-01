using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverEscena : MonoBehaviour
{
    // private int escena;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     escena=SceneManager.GetActiveScene().buildIndex-1;
    // }
    string escena = "Escena1";
   
    public void mover(){
        SceneManager.LoadScene(escena);
    }
}