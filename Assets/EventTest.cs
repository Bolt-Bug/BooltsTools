using System;
using NaughtyAttributes;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    [BoltsSave(SavedVariableType.String)]
    public string testSaeThing;
}