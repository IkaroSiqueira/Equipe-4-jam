using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vida : MonoBehaviour
{
   public Slider slider;

   public void Fvida(float Vid)
   {
       slider.maxValue = Vid;
       slider.value = Vid;
   }
   public void SetVid(float Vid)
   {
       slider.value = Vid;
   }
}
