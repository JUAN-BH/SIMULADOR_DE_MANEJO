using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_C1 : MonoBehaviour
{
    public float velocidad = 0.02f;
    public float limiteInferior = 0.0f;
    public float limiteSuperior = 0.0f;
    public Vector3 posicionInicial = new Vector3(21, 1.4f, 87);

    //x -1.026611    z -4.146184

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limiteSuperior
         || transform.position.x < limiteInferior)
        {
            velocidad = velocidad * -1;
        }

        this.transform.position += new Vector3(velocidad, 0, velocidad);

    }
}