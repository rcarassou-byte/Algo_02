using UnityEngine;

public class Exercice2 : MonoBehaviour
{
    int ageJoueur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ageJoueur = 10;
        if (ageJoueur <= 18)
        {
            Debug.Log("Bye");
        }
        else
        {
            Debug.Log("Bienvenue sur le jeu");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
