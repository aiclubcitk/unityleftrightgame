using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField]private List<Sprite> EnemiesSpriteList;
    [SerializeField]private GameObject EnemyPrefab;
    [SerializeField]private List<Sprite> FoodSpriteList;
    [SerializeField]private GameObject FoodPrefab;
    [SerializeField]private Transform spawnerParent;
    [SerializeField]private List<GameObject> SpawnLocations;
    [SerializeField]private float SpawnTime;
    [SerializeField]private float SpawnTimeFood;
    private float SpawnTimeCounter;
    private float SpawnTimeCounterFood;
    private int RandomSpawnLocation;
    private int RandomEnemy;
    private int RandomFood;
    private int Timer;
    public bool canSpawn = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(canSpawn){
            spawnermethod();
        }
        
    }
    void spawnermethod(){
        SpawnTimeCounter += Time.deltaTime;
        SpawnTimeCounterFood += Time.deltaTime;
        if(SpawnTimeCounter >= SpawnTime){
            RandomSpawnLocation = Random.Range(0, SpawnLocations.Count);
            RandomEnemy = Random.Range(0, EnemiesSpriteList.Count);
            GameObject Enemy = Instantiate(EnemyPrefab, SpawnLocations[RandomSpawnLocation].transform.position, Quaternion.identity);
            Enemy.GetComponent<Image>().sprite = EnemiesSpriteList[RandomEnemy];
            Enemy.transform.SetParent(spawnerParent);
            SpawnTimeCounter = 0;
        }
        if(SpawnTimeCounterFood >= SpawnTimeFood){
            RandomSpawnLocation = Random.Range(0, SpawnLocations.Count);
            RandomFood = Random.Range(0, FoodSpriteList.Count);
            GameObject Food = Instantiate(FoodPrefab, SpawnLocations[RandomSpawnLocation].transform.position, Quaternion.identity);
            Food.transform.SetParent(spawnerParent);
            Food.GetComponent<Image>().sprite = FoodSpriteList[RandomFood];
            SpawnTimeCounterFood = 0;
        }

    }
}
