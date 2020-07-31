using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infecção : MonoBehaviour
{
    int IN;
    public float Dtime = 5.0f;
    public bool infected = false;
    public ControladorDeVida Con;
    public void infec()
    {
        IN = Random.Range(1, 101);
        if (IN >= 80)
        {
            Debug.Log("Esta infectado");
            infected = true;
        }
        else
        {
            Debug.Log("Não esta");
        }
    }
    void Update()
    {
        if (infected == true)
        {
            Dtime -= Time.deltaTime;
            if (Dtime < 0)
            {
                Con.dano(25);
                Dtime = 5.0f;
            }
        }
    }
}
