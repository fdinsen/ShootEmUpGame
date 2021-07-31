using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealthHandler
{
    public void DealDamage(int damage);

    public void HealHealth(int healBy);

    public void Die();

}
