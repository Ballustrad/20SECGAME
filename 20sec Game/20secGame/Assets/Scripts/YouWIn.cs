using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWIn : MonoBehaviour
{
    public string sceneToLoad; // Nom de la sc�ne � charger

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Finish") { // V�rifie si le joueur est entr� en collision avec le cube
            SceneManager.LoadScene(sceneToLoad); // Charge la sc�ne sp�cifi�e
        }
    }
    
   

}
