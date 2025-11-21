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
    public GameObject powerobj2;
    public bool canpowerup2 = true;
    public float powercoldown2;
    public GameObject motherobj;
    public bool canmother= true;
    public float mothercoldown;

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

        if (powerobj2 != null && canpowerup2 == true)
        {
            StartCoroutine(Powerup2());
            canpowerup2 = false;
        }
        if (motherobj != null && canmother == true)
        {
            StartCoroutine(Mother());
            canmother = false;
        }

    }

    private IEnumerator EnemySpawner()
    {
        yield return new WaitForSeconds(spawnCooldown);
        if (minValue == 0 && maxValue == 0)
        {
            Instantiate(enemyGameObject, transform.position, Quaternion.identity);
        }
        else
        {
            Vector2 randomLocation = new Vector2(Random.Range(minValue, maxValue), transform.position.y);
            Instantiate(enemyGameObject, randomLocation, Quaternion.identity);
        }
        canspawn = true;
    }
    private IEnumerator EnemySpawner2()
    {
        yield return new WaitForSeconds(spawnCooldown2);
        if (minValue == 0 && maxValue == 0)
        {
            Instantiate(enemyGameObject2, transform.position, Quaternion.identity);
        }
        else
        {
            Vector2 randomLocation = new Vector2(Random.Range(minValue, maxValue), transform.position.y);
            Instantiate(enemyGameObject2, randomLocation, Quaternion.identity);
        }
        canspawn2 = true;
    }
    private IEnumerator Powerup1()
    {
        yield return new WaitForSeconds(powercoldown);
        if (minValue == 0 && maxValue == 0)
        {
            Instantiate(powerobj, transform.position, Quaternion.identity);
        }
        else
        {
            Vector2 randomLocation = new Vector2(Random.Range(minValue, maxValue), transform.position.y);
            Instantiate(powerobj, randomLocation, Quaternion.identity);
        }
        canpowerup = true;
    }

    private IEnumerator Powerup2()
    {
        yield return new WaitForSeconds(powercoldown2);
        if (minValue == 0 && maxValue == 0)
        {
            Instantiate(powerobj2, transform.position, Quaternion.identity);
        }
        else
        {
            Vector2 randomLocation = new Vector2(Random.Range(minValue, maxValue), transform.position.y);
            Instantiate(powerobj2, randomLocation, Quaternion.identity);
        }
        canpowerup2 = true;
    }
    private IEnumerator Mother()
    {
        yield return new WaitForSeconds(mothercoldown);
        if (minValue == 0 && maxValue == 0)
        {
            Instantiate(enemyGameObject, transform.position, Quaternion.identity);
        }
        else
        {
            Vector2 randomLocation = new Vector2(Random.Range(minValue, maxValue), transform.position.y);
            Instantiate(motherobj, randomLocation, Quaternion.identity);
        }
        canmother = true;
    }
}
