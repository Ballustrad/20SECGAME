using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWIn : MonoBehaviour
{
    public string sceneToLoad; // Nom de la scène à charger

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Finish") { // Vérifie si le joueur est entré en collision avec le cube
            SceneManager.LoadScene(sceneToLoad); // Charge la scène spécifiée
        }
    }
    
   

}
