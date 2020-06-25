using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class M_A2S : MonoBehaviour
{

    SerialPort sp2 = new SerialPort("COM5", 9600);

    // Start is called before the first frame update
    void Start()
    {
        sp2.Open();
        sp2.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (sp2.IsOpen)
        {
            try
            {
                acelerar(sp2.ReadByte());
                frenar(sp2.ReadByte());
            }
            catch (System.Exception) { }
        }
    }


    void acelerar(int direccion)
    {
        if (direccion == 1)
        {
            transform.Translate(Vector3.forward * 15f * Time.deltaTime);
        }

        if (direccion == 3)
        {
            transform.Translate(Vector3.forward * 30f * Time.deltaTime);
        }
    }


    void frenar(int direccion)
    {
        if (direccion == 2)
        {
            transform.Translate(Vector3.back * 30f * Time.deltaTime);
        }

        if (direccion == 4)
        {
            transform.Translate(Vector3.back * 0f * Time.deltaTime);
        }
    }
}

