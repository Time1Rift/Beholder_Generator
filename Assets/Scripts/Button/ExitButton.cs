using System;
using UnityEngine;

public class ExitButton : ButtonAbstract
{
    [SerializeField] private GameObject _object;

    public event Action ButtonExit;

    protected override void OnButtonClick()
    {
        _object.SetActive(false);
        ButtonExit?.Invoke();
    }
}