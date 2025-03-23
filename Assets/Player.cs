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
        Debug.Log($"����� ü���� {base.hp}, ���ݷ��� {base.damage}�Դϴ�");
    }

    public Knight(int damage, int hp) : this()
    {
        base.damage = damage;
        base.hp = hp;
        Debug.Log($"����� ü���� {base.hp}, ���ݷ��� {base.damage}�Դϴ�");
    }

    public override void Attack()
    {
        Debug.Log("Į�� �ֵθ���");
        Debug.Log($"������� Į�� {this.damage}������ �־���");

    }

}

public class Archer : Player
{
    public Archer()
    {
        base.damage = 40;
        base.hp = 100;
        Debug.Log($"�ü��� ü���� {base.hp}, ���ݷ��� {base.damage}�Դϴ�");
    }

    public Archer(int damage, int hp) : this()
    {
        base.damage = damage;
        base.hp = hp;
        Debug.Log($"�ü��� ü���� {base.hp}, ���ݷ��� {base.damage}�Դϴ�");
    }

    public override void Attack()
    {
        Debug.Log("ȭ�� �߻��ϱ�");
        Debug.Log($"������� ȭ��� {this.damage}�������� �־���");
    }

}



