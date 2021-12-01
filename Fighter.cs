using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public string nombre ;
    public string category ;
    public int health;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void showEnemy()
    {
        Debug.Log("El nombre es "+this.nombre+" su categoria "+this.category+" y su salud "+this.health);
    }
}
