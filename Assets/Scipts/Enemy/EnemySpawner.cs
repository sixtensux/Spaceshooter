using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemylist;

    Vector2 spawnPoint;
    [Space]
    [Space]
    [Space]
    public float spawnrate;
    float randy;
    float nextspawn;

	

    public float randRange1 = 4;
    public float randRange2 = -4;

    void Update()
    {


		if (Time.time > (nextspawn))
        {
            nextspawn = Time.time + spawnrate;
            randy = Random.Range(randRange1, randRange2);
            spawnPoint = new Vector2(transform.position.x, randy);
            Instantiate(enemylist[Random.Range(0, enemylist.Length)], spawnPoint, Quaternion.identity);
        }
    }
}