using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class M_A2SAR : MonoBehaviour
{

    SerialPort sp2 = new SerialPort("COM5", 9600);
    int ON;
    int OF;
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
                ON = sp2.ReadByte();
                if (ON == 10)
                {
                    acelerar(sp2.ReadByte());
                }
                //OF = sp2.ReadByte();
                //if (OF == 11)
                else{
                    reversa(sp2.ReadByte());
                }
            }
            catch (System.Exception) { }
        }
    }


    void acelerar(int direccion)
    {
        if (direccion == 1)
        {
            transform.Translate(Vector3.forward * 25f * Time.deltaTime);
        }

        if (direccion == 3)
        {
            transform.Translate(Vector3.forward * 30f * Time.deltaTime);
        }
    }


    //void reversa(int direccion)
    //{
    //    if (direccion == 5)
    //    {
    //        transform.Translate(Vector3.back * 20f * Time.deltaTime);
    //    }

    //    if (direccion == 7)
    //    {
    //        transform.Translate(Vector3.back * 30f * Time.deltaTime);
    //    }
    //}

    void reversa(int direccion)
    {
        if (direccion == 2)
        {
            transform.Translate(Vector3.back * 20f * Time.deltaTime);
        }

        if (direccion == 4)
        {
            transform.Translate(Vector3.back * 25f * Time.deltaTime);
        }
    }
}
