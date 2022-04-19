using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioexamem : MonoBehaviour

{
    public int EdadDeUsuario;
    public string MiTexto;
    public float alturadelusuario;
    // Start is called before the first frame update
    void Start()
    {

        if (EdadDeUsuario >= 13)
        {
            Debug.Log("acesso permitido");
        }

    
    
        else
    {
        Debug.Log("acceso denegado");
            
            if (alturadelusuario >=  1.2)
            {
                Debug.Log("acceso permitido");
            }
            else
            {
                Debug.Log("acceso denegado");
            }
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
