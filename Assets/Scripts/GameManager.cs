using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Monster[] slimes;
    [SerializeField] private float damage;
    private Monster curSlime;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if(curSlime == null)
        {
            SpawnSlime();
        }
    }

    public void SpawnSlime()
    {
        int spawnIndex = UnityEngine.Random.Range(0, slimes.Length);
        GameObject newSlime = Instantiate(slimes[spawnIndex].gameObject);
        curSlime = newSlime.GetComponent<Monster>();
    }

    public void HitSlime()
    {
        if(curSlime != null)
        {
            curSlime.OnHit(damage);
        }
    }
}
