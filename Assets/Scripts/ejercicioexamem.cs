using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioexamem : MonoBehaviour

{
    public int EdadDeUsuario;
    public string MiTexto;
    // Start is called before the first frame update
    void Start()
    {

        if (EdadDeUsuario >= 18)
        {
            Debug.Log("es mayor de edad");
        }

    
    
        else
    {
        Debug.Log("es menor de edad");
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
