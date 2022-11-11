using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float attackDelay;
    public float startDelay;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage; 

    // Start is called before the first frame update
    void Start()
    {
        if(attackDelay <= 0)
        {
            if(Input.GetKey(KeyCode.F))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);

                for(int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
            }

            attackDelay = startDelay; //Restarts the delay
        }
        else
        {
            attackDelay -= Time.deltaTime; //Count Down
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
