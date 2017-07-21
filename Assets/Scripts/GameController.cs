using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject Enemy;
    public Vector3 spawnValues;
    public int enemyCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;


	// Use this for initialization
	void Start () {
        StartCoroutine(EnemySpawn());
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    IEnumerator EnemySpawn ()
    {
        yield return new WaitForSeconds(startWait);
        while(true)
        {
            for (int i = 0; i < enemyCount; i++)
            {
                Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(Enemy, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }

    }
}
