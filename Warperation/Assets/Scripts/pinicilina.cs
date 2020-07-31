using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinicilina : MonoBehaviour
{
    public Infecção infecção;
    public void pin()
    {
        Debug.Log("não esta mais");
        infecção.infected = false;
    }
}
