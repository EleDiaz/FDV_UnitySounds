using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Implementar un script que al pulsar la tecla p accione el movimiento de una
//  esfera en la escena y reproduzca un sonido en bucle hasta que se pulse la tecla s.
public class SphereAttentionOnKey : MonoBehaviour
{
    [Serializable]
    private AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.KeyDown("p")) {
            audio.Play();
        }
        
        if (Input.KeyDown("s")) {
            audio.Stop();
        }
    }
}
