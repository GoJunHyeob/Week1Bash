using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Movey, Combat
{

    private int damage;

    public Goblin()
    {
        this.damage = 10;
        Debug.Log($"����� ���ݷ��� {this.damage}�Դϴ�");
    }

    public Goblin(int damage) : this()
    {
        this.damage = damage;
        Debug.Log($"����� ���ݷ��� {this.damage}�Դϴ�");
    }

    public void Attack(ref Player target)
    {
        target.Hp = target.Hp - this.damage;
        Debug.Log($"�÷��̾��� ü���� {target.Hp}���Ҵ�");
    }

    public void Movex(int x)
    {
        Debug.Log($"x��ǥ�� {x}���� �̵�");
    }

    public void Movey(int y)
    {
        Debug.Log($"y��ǥ�� {y}���� �̵�");
    }
}
