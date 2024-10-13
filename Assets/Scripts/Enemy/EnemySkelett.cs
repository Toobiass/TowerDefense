using UnityEngine;

public class EnemySkelett : MonoBehaviour, IEnemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    void Start()  
    {
        Name = "Skelett";
        Health = 5;
        Damage = 1;
    }

    void Update()  // Unity's Update method
    {
        // Update enemy logic
    }

    public void Attack()
    {
        // Attack logic
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        // Logic when the enemy dies
        Destroy(gameObject);  // Example of destroying the enemy in Unity
    }

    public void CreateEnemy()
    {
        throw new System.NotImplementedException();
    }

    void IEnemy.Update()
    {
        throw new System.NotImplementedException();
    }
}
