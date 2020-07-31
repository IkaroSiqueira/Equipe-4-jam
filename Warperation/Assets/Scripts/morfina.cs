using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morfina : MonoBehaviour
{
    public Dor DC;
    public void Mor()
    {
        if (DC.D >=1)
        {
            DC.H = DC.D - 1;
        }
    }
}
