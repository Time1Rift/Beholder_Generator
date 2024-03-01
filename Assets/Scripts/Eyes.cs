using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    [SerializeField] private List<Eye> _eyes;

    public Eye GetEye() => _eyes[Random.Range(0, _eyes.Count)];
}