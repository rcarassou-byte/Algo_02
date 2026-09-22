using UnityEngine;

public class Clonage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject mob;
    void Start()
    {
        Instantiate(mob, new Vector3(0,1,0), Quaternion.identity);
        Instantiate(mob, new Vector3(1,1,0), Quaternion.identity);
        Instantiate(mob, new Vector3(2,1,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
