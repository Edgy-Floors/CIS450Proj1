using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    public void updateCount(int count, int target);
}
