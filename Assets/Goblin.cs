using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Movey, Combat
{

    private int damage;

    public Goblin()
    {
        this.damage = 10;
        Debug.Log($"고블린의 공격력은 {this.damage}입니다");
    }

    public Goblin(int damage) : this()
    {
        this.damage = damage;
        Debug.Log($"고블린의 공격력은 {this.damage}입니다");
    }

    public void Attack(ref Player target)
    {
        target.Hp = target.Hp - this.damage;
        Debug.Log($"플레이어의 체력이 {target.Hp}남았다");
    }

    public void Movex(int x)
    {
        Debug.Log($"x좌표를 {x}까지 이동");
    }

    public void Movey(int y)
    {
        Debug.Log($"y좌표를 {y}까지 이동");
    }
}
