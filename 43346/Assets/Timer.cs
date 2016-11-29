using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
    public static int timersecond = 0; 
    public static float secondgametime; 
    public static float minedgametime = 0;
    void Update()
    { 

        secondgametime += Time.deltaTime;
        
        if (secondgametime >= 1)
        {
            
            timersecond += 1;
            
            secondgametime = 0; 
        }
       
        if (timersecond >= 60)
        {
      
            minedgametime += 1;
       
            timersecond = 0;
        }
   
        if (minedgametime >= 60)
        {
           
            minedgametime = 0; 
                               
                             
        }
    }
   
    void OnGUI()
    {
       
        GUI.Label(new Rect(Screen.width - 500, 10, 100, 50), "SecondTime : " + timersecond);
        GUI.Label(new Rect(Screen.width - 500, 25, 100, 50), "MinutesTime : " + minedgametime);
    }
}