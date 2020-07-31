using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infecção : MonoBehaviour
{
    int IN;
    public void infec()
    {
        IN = Random.Range(1,100);
        if(IN >=80)
        {
            Debug.Log("Esta infectado");
        }
        else
        {
            Debug.Log("Não esta");
        }
    }
}
