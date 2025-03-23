using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player
{
    protected int hp;
    public int Hp
    {
        get => hp;
        set
        {
            if (hp > 0)
            {
                hp = value;
            }
            else
            {
                hp = 0;
            }
        }
    }
    protected int damage;

    public abstract void Attack();

}

public class Knight : Player
{

    public Knight()
    {
        base.damage = 40;
        base.hp = 100;
        Debug.Log($"기사의 체력은 {base.hp}, 공격력은 {base.damage}입니다");
    }

    public Knight(int damage, int hp) : this()
    {
        base.damage = damage;
        base.hp = hp;
        Debug.Log($"기사의 체력은 {base.hp}, 공격력은 {base.damage}입니다");
    }

    public override void Attack()
    {
        Debug.Log("칼을 휘두르기");
        Debug.Log($"고블린에게 칼로 {this.damage}데미지 주었다");

    }

}

public class Archer : Player
{
    public Archer()
    {
        base.damage = 40;
        base.hp = 100;
        Debug.Log($"궁수의 체력은 {base.hp}, 공격력은 {base.damage}입니다");
    }

    public Archer(int damage, int hp) : this()
    {
        base.damage = damage;
        base.hp = hp;
        Debug.Log($"궁수의 체력은 {base.hp}, 공격력은 {base.damage}입니다");
    }

    public override void Attack()
    {
        Debug.Log("화살 발사하기");
        Debug.Log($"고블린에게 화살로 {this.damage}데미지를 주었다");
    }

}



