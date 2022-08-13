using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlInterfaz : MonoBehaviour
{
    private string texto="Tu nombre";
    private int avance = 1;
    // Variable para la rotacion
    public float rotacion=0.0f;
    // Variable para saber si hay o no movimiento
    private bool movimiento = false;
    void Start()
    {
    }
    void Update()
    {
    }
    void OnGUI()
    {
        // Variables para la posicion
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        // Variables para la rotacion
        float xr = transform.rotation.eulerAngles.x;
        float yr = transform.rotation.eulerAngles.y;
        float zr = transform.rotation.eulerAngles.z;
        // Etiqueta para el texto
        GUI.Label(new Rect(10, 10, 200, 30), "Hola : "+texto);
        // Etiqueta para la posicion
        GUI.Label(new Rect(10, 50, 120, 30),x.ToString()+","+y.ToString()+","+z.ToString());
        // Colocamos una caja
        GUI.Box (new Rect(10,90, 120, 30), xr.ToString()+","+yr.ToString()+","+zr.ToString());

        // Colocamos boton y verifi camos si se oprime
        if(GUI.Button(new Rect(40,140,60,30),"Arriba"))
            transform.Translate(0,avance,0); // Movemos el cubo hacia arriba

        // Colocamos boton y verifi camos si se oprime
        if(GUI.Button(new Rect(10,170,60,30),"Izquierda"))
            transform.Translate(-avance,0,0); // Movemos el cubo hacia la izquierda

        // Colocamos boton y verifi camos si se oprime
        if(GUI.Button(new Rect(70,170,60,30),"Derecha"))
            transform.Translate(avance,0,0); // Movemos el cubo hacia la derecha

        // Colocamos boton y verifi camos si se oprime
        if(GUI.Button(new Rect(40,200,60,30),"Abajo"))
            transform.Translate(0,-avance,0); // Movemos el cubo hacia abajo 
        // Peticion de un texto
        texto = GUI.TextField(new Rect(250,10,200,30),texto,25);

         // Slider para el valor de rotacion
        rotacion = GUI.HorizontalSlider(new Rect(10,230,100,30), rotacion, -45.0f , 45.0f );
        // Colocamos la rotacion en el eje Y
        //transform.rotation.eulerAngles.y=rotacion;
        rotacion=transform.rotation.eulerAngles.y;

        // Toggle para el movimiento
         movimiento = GUI.Toggle(new Rect(10,260,100,30),movimiento, "Permitir avance");
        // Verifi camos si hay movimiento o no
        if(movimiento==true)
            avance=1;
        else
            avance=0;
    }
}
