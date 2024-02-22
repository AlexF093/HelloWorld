using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hellowworld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = new Enemy("Voldemor", 100, true);
        Player player = new Player("HP", 500, true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
