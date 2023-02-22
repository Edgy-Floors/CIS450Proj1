using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SmellBehavior: MonoBehaviour
{
    public int smellBehaviorIndex = -1;

    public abstract void Smell();
}
