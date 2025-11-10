using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject enemyGameObject;
    public float spawnCooldown;
    public bool canspawn = true;
    public GameObject powerobj;
    public bool canpowerup = true;
    public float powercoldown;
    public GameObject enemyGameObject2;
    public float spawnCooldown2;
    public bool canspawn2 = true;

    [Header("Randomise Spawn Location")]
    public float minValue;
    public float maxValue;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyGameObject2 != null && canspawn2 == true)
        {
            StartCoroutine(EnemySpawner2());
            canspawn2 = false;
        }
        if (enemyGameObject != null && canspawn == true)
        {
            StartCoroutine(EnemySpawner());
            canspawn = false;
        }
        
        if (powerobj != null && canpowerup == true)
        {
            StartCoroutine(Powerup1());
            canpowerup = false;
        }
        
    }

    private IEnumerator EnemySpawner()
    {
        if (minValue == 0 && maxValue == 0)
        {
            Instantiate(enemyGameObject, transform.position, Quaternion.identity);
        }
        else
        {
            Vector2 randomLocation = new Vector2(Random.Range(minValue, maxValue), transform.position.y);
            Instantiate(enemyGameObject, randomLocation, Quaternion.identity);
        }
        yield return new WaitForSeconds(spawnCooldown);
        canspawn = true;
    }
    private IEnumerator EnemySpawner2()
    {
        if (minValue == 0 && maxValue == 0)
        {
            Instantiate(enemyGameObject2, transform.position, Quaternion.identity);
        }
        else
        {
            Vector2 randomLocation = new Vector2(Random.Range(minValue, maxValue), transform.position.y);
            Instantiate(enemyGameObject2, randomLocation, Quaternion.identity);
        }
        yield return new WaitForSeconds(spawnCooldown2);
        canspawn2 = true;
    }
    private IEnumerator Powerup1()
    {
        if (minValue == 0 && maxValue == 0)
        {
            Instantiate(powerobj, transform.position, Quaternion.identity);
        }
        else
        {
            Vector2 randomLocation = new Vector2(Random.Range(minValue, maxValue), transform.position.y);
            Instantiate(powerobj, randomLocation, Quaternion.identity);
        }
        yield return new WaitForSeconds(powercoldown);
        canpowerup = true;
    }
}
