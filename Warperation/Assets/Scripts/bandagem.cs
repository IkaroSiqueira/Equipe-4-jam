using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandagem : MonoBehaviour
{
    public vida V;
    public ControladorDeVida VC;
    public void Band()
    {
        VC.cura(50);
    }
}
