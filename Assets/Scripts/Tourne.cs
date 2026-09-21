using UnityEngine;

public class Tourne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("je suis Enabled");
    }
    private void Update()
    {
        Debug.Log("je suis dans l'update");
    }
    private void OnDestroy()
    {
        Debug.Log("Je suis mort");
    }

}
