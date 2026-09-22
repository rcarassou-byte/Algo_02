using Unity.VisualScripting;
using UnityEngine;

public class Spawner
    : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject mob;
    void Start()
    {
        Instantiate(mob, new Vector3(0,1,0), Quaternion.identity);
        for (int i = 0; i < 100; i++)
        {
           for (int j = 0; j < 100; j++)
           {
                if (i == 1 || j == 1 || i ==99 || j ==99)
                {
                    Instantiate(mob, new Vector3(i, 2, j), Quaternion.identity);
                    Instantiate(mob, new Vector3(i, 3, j), Quaternion.identity);
                    if (i == 1 && j == 1 || i == 1 && j == 99 || i == 99 && j == 99 || i == 99 && j == 1)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            Instantiate(mob, new Vector3(i, k, j), Quaternion.identity);
                        }
                    }

                }
                else
                {
                    Instantiate(mob, new Vector3(i, 1, j), Quaternion.identity);
                }



            }
        }
        }
    }
        

// Update is called once per frame