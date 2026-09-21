using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject mob;
    public KeyCode E = KeyCode.E;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        Instantiate(mob, new Vector3(1,1,1), Quaternion.identity);
        Instantiate(mob, new Vector3(2,1,1), Quaternion.identity);
        Instantiate(mob, new Vector3(3,1,1), Quaternion.identity);

    }
}
