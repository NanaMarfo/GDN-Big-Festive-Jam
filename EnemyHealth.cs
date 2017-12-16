using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Health = 10f;

    public void TakeDamage(float DamageTaken)
    {
        Health -= DamageTaken;
        if(Health <= 0f)
        {
            Die();
        }

    }

    void Die()
    {
        Destroy(gameObject);
        Debug.Log("Enemy Killed!");
    }
}