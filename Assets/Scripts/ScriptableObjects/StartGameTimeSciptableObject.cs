using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStartTime", menuName = "ScriptableObjects/StartTime", order = 1)]
public class StartGameTimeSciptableObject : ScriptableObject
{
    public long ticks;
}
