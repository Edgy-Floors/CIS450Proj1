/*
 * Nick Grinstead
 * SmellBehavior.cs
 * This abstract class represents the behavior of a flower when smelt.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SmellBehavior: MonoBehaviour
{
    public int smellBehaviorIndex = -1;

    public abstract void Smell();
}
