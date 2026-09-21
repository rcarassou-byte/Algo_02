using UnityEngine;

public class Truc : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake"); 
    }

    private void OnEnable()
    {
        Debug.Log("Enabled");    
    }

    private void Update()
    {
        Debug.Log("Update");
    }


    private void OnDestroy()
    {
        Debug.Log("Destroyer");
    }
}



