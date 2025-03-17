using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DeclaracionDeVariables : MonoBehaviour
{
    int EdadUsuario;
    float precio;
    string NombreUsuario;
    bool vivo;


    // Start is called before the first frame update
    void Start()
    {
        EdadUsuario = 64;
        precio = 1550.00f;
        NombreUsuario = "Pepe";
        vivo = true;

        // escribo las variables en consola
        Debug.Log(EdadUsuario);
        Debug.Log(precio);
        Debug.Log(NombreUsuario);
        Debug.Log(vivo);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
