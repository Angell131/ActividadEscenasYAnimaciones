using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    private float  numeros;
    private TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    private void Start()
    {
        textMesh=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
   private void Update()
    {
        numeros += Time.deltaTime;
        textMesh.text=numeros.ToString("0");
    }
}
