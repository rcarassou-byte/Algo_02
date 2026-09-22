using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sol;
    public GameObject mur;
    public int RandomSol;
    public KeyCode spawn = KeyCode.E;
    public int compteur = 0;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                int rng = Random.Range(0, 10);
                if (rng < 8)
                {
                    

                    if (i == 0 || j == 0 || i == 99 || j == 99)
                    {
                        Instantiate(sol, new Vector3(i, 1, j), Quaternion.identity);
                        Instantiate(sol, new Vector3(i, 2, j), Quaternion.identity);

                            if (i == 0 && j == 0 || i == 0 && j == 99 || i == 99 && j == 99 || i == 99 && j == 0)
                        {
                            for (int k = 0; k < 100; k++)
                            {
                                Instantiate(sol, new Vector3(i, k, j), Quaternion.identity);
                            }
                        }
                    }
                    else Instantiate(sol, new Vector3(i, 0, j), Quaternion.identity);

                }


            }



        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}
