using System.Collections;
using System.Collections.Generic;
using TD_CGO;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Hp;
    public float Dmg;
    public float Speed;

    [SerializeField] EnemyMovement enemyMovement;

    private void Start()
    {
        StartMove();
    }

    void StartMove()
    {
        enemyMovement.speed = Speed;
    }
}
