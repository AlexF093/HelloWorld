using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character
{
    public Character(string name, int vida, Boolean vivo)
    {
        Debug.Log("Hola soy " + name + " tengo " + vida + " puntos de vida "+ "y estoy " + vivo);
    }
        
    
}