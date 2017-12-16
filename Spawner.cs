using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public Wave[] waves;
    public  enemy;

    int enemiestospawn;
    float spawntime;
    Wave currentwave;
    int currentwaveno;

    void Start()
    {
        NextWave();
    }

    void Update()
    {
        if(enemiestospawn > 0 && Time.time > spawntime)
        {
            enemiestospawn--;
            spawntime = Time.time + currentwave.TimeBetweenSpawns;

            Enemy spawnedEnemy = Instantiate(enemy, Vector3.zero, Quaternion.identity) as Enemy;
        }
    }

    void NextWave()
    {
        currentwaveno++;
        currentwave = waves[currentwaveno = 1];

        enemiestospawn = currentwave.enemyCount;
    }
    [System.Serializable]
    public class Wave
    {
        public int enemyCount;
        public float TimeBetweenSpawns;
    }
}