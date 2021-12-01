using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] personajes;
    public List<string> nombres = new List<string>();
    public List<string> categoria = new List<string>();
    public List<int> vida = new List<int>() { 100 };

    public void InitFighters(List<string> nombres, List<string> categoria)
    {
        foreach (GameObject obj in personajes)
        {
            Fighter datos = obj.GetComponent<Fighter>();

            foreach (string names in nombres)
            {
                datos.nombre = names; 
            }
            foreach (string value in categoria)
            {
                datos.category = value;
            }
            foreach (int life in vida)
            {
                datos.health = life;
            }
           

            datos.showEnemy();
        }
    }
    void Start()
    {
        personajes = GameObject.FindGameObjectsWithTag("Jugador");

        if (personajes.Length != 0)
        {
            Debug.Log("Se han encontrado " + personajes.Length + " objetos");
            nombres.Add("Scorpion");nombres.Add("Kano");nombres.Add("Sonya");nombres.Add("Johnny Cage");nombres.Add("Sub-Zero");
            categoria.Add("Ninja");categoria.Add("Mercenario");categoria.Add("Teniente");categoria.Add("Actor");categoria.Add("Ninja");
        }

        InitFighters(nombres,categoria);
    }

 
    void Update()
    {
        
    }

  
}
