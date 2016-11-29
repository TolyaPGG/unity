using UnityEngine;
using System.Collections;

public class OnPark : MonoBehaviour {
    public GameObject menu;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "park2")
        {
            menu.SetActive(!menu.activeSelf);
        }

    }
    
    
   

}



