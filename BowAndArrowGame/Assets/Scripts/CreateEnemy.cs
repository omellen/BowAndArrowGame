using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemy;
    private int xPos;
    private int zPos;
    private int enemyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(EnemyDrop());
    }

    IEnumerable EnemyDrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(-10, 10);
            zPos = 20;
            Instantiate(enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;

        }
    } 
}
