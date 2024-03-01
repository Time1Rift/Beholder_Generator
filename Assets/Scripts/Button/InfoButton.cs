using System;
using UnityEngine;

public class InfoButton : ButtonAbstract
{
    [SerializeField] private GameObject _object;

    public event Action ButtonClicked;

    private void Awake()
    {
        _object.SetActive(false);
    }

    protected override void OnButtonClick()
    {
        _object.SetActive(true);
        ButtonClicked?.Invoke();
    }
}