using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDeVida : MonoBehaviour
{
    public float vidamaxima = 100;
    public float vidatual;
    public vida V;
    void Start()
    {
        vidatual = vidamaxima;
        V.Fvida(vidamaxima);
        Time.timeScale = 1f;
    } 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dano(20);
        }
    }
    void dano(float Dalor)
    {
        vidatual -= Dalor;
        V.SetVid(vidatual);
    }
    public void cura(float Halor)
    {
        vidatual += Halor;
        V.SetVid(vidatual);
    }
}
