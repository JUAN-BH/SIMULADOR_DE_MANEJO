using UnityEngine;
using System.Collections;
using System;
using System.IO.Ports;

public class M_A : MonoBehaviour {
    SerialPort sp = new SerialPort("COM5", 9600);
    int ON;
    private AudioSource son;
    // Use this for initialization
    void Start () {     
        sp.Open();
        sp.ReadTimeout = 1;
        son = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {

        if (sp.IsOpen) {
            try {

                //string un = sp.ReadLine();
                ON = sp.ReadByte();

                if (ON == 10)
                {
                    
                    movimiento(sp.ReadByte());
                    
                }
                else {
                    //se apaga el carro
                    son.Play();
                }
            }
            catch (System.Exception) { }
        }

    }

    void movimiento(int direccion) { 
          
        if (direccion == 1) {         
            transform.Translate(Vector3.forward * 15f * Time.deltaTime);
        }

        if (direccion == 2) {       
            transform.Translate(Vector3.forward * 25f * Time.deltaTime);
        }

        if (direccion == 3) {        
            transform.Translate(Vector3.back * 15f * Time.deltaTime);
        }

        if (direccion == 4) {       
            transform.Translate(Vector3.back * 0f * Time.deltaTime);
        }

        /* if (direccion == 2)
         {
             transform.Translate(Vector3.right * speed * Time.deltaTime);
         }*/
    }
}
