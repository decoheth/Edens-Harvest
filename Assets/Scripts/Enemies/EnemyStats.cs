using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    // public int spawnCost
    public  Faction selectedFaction;

    GameObject enemyManager;

    void Awake ()
    {
        enemyManager = GameObject.Find("/Managers/Enemy Manager");

        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        { Death(); }
    }

    void Death()
    {
        enemyManager.GetComponent<WaveManager>().currentEnemyWave.Remove(gameObject);
        Destroy(gameObject);
        // Drop Loot
        GetComponent<DropLoot>().dropLoot();
    }

}

[System.Serializable]
public enum Faction
{
    PLAYER,
    RAIDER,
    PARAMILITARY,
    ORGANIC,

}

