using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dor : MonoBehaviour
{
    public int D = 0;
    public int H = 0;
    public void dor(int H)
    {
        D =Random.Range(1, 4);
        switch (D)
        {
            case 1:
                Debug.Log("dor verde");
                break;
            case 2:
                Debug.Log("dor amarela");
                break;
            case 3:
                Debug.Log("dor vermelha");
                break;
            default:
                Debug.Log("WTF");
                break;
        }
    }
    public void Update()
     {
        switch (H)
        {
            case 1:
                Debug.Log("dor verde");
                H=0;
                D = 0;
                break;
            case 2:
                Debug.Log("dor amarela");
                H=0;
                D = 2;
                break;
            case 3:
                Debug.Log("dor vermelha");
                H=0;
                D = 0;
                break;
            default:
            break;
        }
    }
}
