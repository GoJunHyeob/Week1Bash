using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{
    void Awake()
    {
        Player one = new Knight();
        Player two = new Archer(150,90);
        Goblin GO = new Goblin();
        GO.Attack(ref two);
        GO.Movey(10);
        GO.Movex(20);
        one.Attack();
    }

}
