using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Movex
{
    public void Movex(int X);
}

interface Movey : Movex
{
    public void Movey(int y);
}

interface Combat
{
    public void Attack(ref Player target);
}
