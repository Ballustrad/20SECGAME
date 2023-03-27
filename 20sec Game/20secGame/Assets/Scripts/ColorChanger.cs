using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color[] colors; // Tableau de couleurs
    public float timeBetweenColors = 1f; // Temps entre chaque changement de couleur

    private Renderer renderer;
    private int currentColorIndex = 0;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenColors);
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            renderer.material.color = colors[currentColorIndex];
        }
    }
}
