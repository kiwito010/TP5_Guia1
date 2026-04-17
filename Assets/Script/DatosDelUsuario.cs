using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
        public int edad;
        public string nombre;
        public bool donante;
        public float estatura;
        string respuesta;
    // Start is called before the first frame update
    void Start(){
     if (donante=true){
        respuesta = "soy ";
    }
     else{
     respuesta="no soy ";
    }

     Debug.Log("mi nombre es "+nombre +", tengo "+ edad+ " años, mido "+ estatura+" metros y "+ respuesta+ "donante.");
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
