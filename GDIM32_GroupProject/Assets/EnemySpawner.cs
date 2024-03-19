using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float countdown;
    [SerializeField]
    protected Wave[] differentSpawnPatterns;
    [SerializeField]
    private int numOfWaves;
    [SerializeField]
    private int nextWave;
    [SerializeField]
    private int riftIndex;
    [SerializeField]
    protected GameObject[] Rifts;
    [SerializeField]
    public float timeToNextRift;
    private EnemyCommon setter;

    // Start is called before the first frame update
    void Start()
    {
        numOfWaves = differentSpawnPatterns.Length;
        Randomize();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Debug.Log("Rift shutdown");
            countdown = timeToNextRift;
            Rifts[riftIndex].SetActive(false);
            SpawnWave();
            Randomize();
        }
    }

    private void Randomize()
    {
        nextWave = Random.Range(0, numOfWaves);
        riftIndex = Random.Range(0, Rifts.Length);
    }

    private void SpawnWave()
    {
        Rifts[riftIndex].SetActive(true);
        for(int i = 0; i < differentSpawnPatterns[nextWave].enemies.Length; i++)
        {
            Instantiate(differentSpawnPatterns[nextWave].enemies[i] ,Rifts[riftIndex].transform);
            setter = differentSpawnPatterns[nextWave].enemies[i].GetComponent<EnemyCommon>();
            Debug.Log(riftIndex);
            setter.setWayPoint(Rifts[riftIndex]);
        }
    }

    [System.Serializable]
    public class Wave
    {
        public EnemyBase[] enemies;
    }
}
