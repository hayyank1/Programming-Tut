using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //This class holds all the info related to the Enemies

    [SerializeField] int _enemyHealth;
    [SerializeField] int _enemyPoints;
    [SerializeField] float _enemySpeed;

    [SerializeField] Transform player;

    //Get methods
    public int GetEnemyHealth()
    {
        return _enemyHealth;
    }
    
    public int GetEnemyPoints()
    {
        return _enemyPoints;
    }    
    
    public float GetEnemySpeed()
    {
        return _enemySpeed;
    }

    public Transform GetPlayeTransform()
    {
        return player;
    }


    //setter methods
    public void SetEnemyHealth(int enemyHealth)
    {
        _enemyHealth = enemyHealth; 
    }

    public void SetEnemyPoints(int enemyPoints)
    {
        _enemyPoints = enemyPoints;
    }

    public void SetEnemySpeed(float enemySpeed)
    {
        _enemySpeed = enemySpeed;
    }

    //Miscelaneous Methods
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
    }


    //this method is virtual as different types of enemies will have different movement
    public virtual void EnemyMovement()
    {
        var move = _enemySpeed * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, player.position, move); 
    }

}
