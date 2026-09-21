using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mob;
    public KeyCode spawn = KeyCode.E;

    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Instantiate(mob, new Vector3(1, 1, 1), Quaternion.identity);
            Instantiate(mob, new Vector3(2, 1, 1), Quaternion.identity);
            Instantiate(mob, new Vector3(3, 1, 1), Quaternion.identity);
        }

    }

}
