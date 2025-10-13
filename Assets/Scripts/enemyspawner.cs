using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject enemyGameObject;
    public float spawnCooldown;
    public bool canspawn = true;

    [Header("Randomise Spawn Location")]
    public float minValue;
    public float maxValue;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyGameObject != null && canspawn == true && spawnCooldown > 0)
        {
            StartCoroutine(EnemySpawner());
            canspawn = false;
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
}
