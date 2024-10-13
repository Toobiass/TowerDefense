using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy
{
    string Name { get; set; }
    int Health { get; set; }
    int Damage { get; set; }
    
    void CreateEnemy();
    void Update();
    void Attack();
    void TakeDamage(int damage);
    void Die();
}
