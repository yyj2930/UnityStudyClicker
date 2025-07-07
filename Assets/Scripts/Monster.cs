using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    [SerializeField] private float maxHp;
    [SerializeField] private string monsterName;

    [SerializeField] private HpBar hpBar;
    [SerializeField] private Text nameText;

    private float curHp;

    private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        curHp = maxHp;
        nameText.text = monsterName;
    }

    public void OnHit(float damage)
    {
        curHp -= damage;
        if (curHp <= 0)
        {
            curHp = 0;
            isDead = true;
        }
        Debug.Log("Slime Hit!, Current Hp : " + curHp);
        hpBar.ChangeHpBarAmount(curHp / maxHp);


        if (isDead)
        {
            Debug.Log("Slime is Dead.");
            Destroy(gameObject, 1.5f);
        }
    }
}
