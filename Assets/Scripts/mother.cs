using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mother : MonoBehaviour
{
    public int enemythealth;
    public float enemyspeed = 1f;
    public GameObject txtobj;
    public GameObject exs;
    public GameObject enemyGameObject2;
    public float spawnCooldown2;
    public bool canspawn2 = true;

    [Header("Randomise Spawn Location")]
    public float minValue;
    public float maxValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        txtobj = GameObject.Find("pointcounter");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * enemyspeed * Time.deltaTime);

        if (enemythealth < 1)
        {
            txtobj.GetComponent<point>().addpoints(1);
            Destroy(this.gameObject);
            Instantiate(exs, transform.position, Quaternion.identity);

        }
        if (enemyGameObject2 != null && canspawn2 == true)
        {
            StartCoroutine(EnemySpawner2());
            canspawn2 = false;
        }
    }

    public void takedamge(int dgtotake)
    {

        enemythealth -= dgtotake;
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
}
