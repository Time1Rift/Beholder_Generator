using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private InfoButton _infoButton;
    [SerializeField] private GeneratorButton _generatorButton;

    [SerializeField] private List<ExitButton> _exitButton;

    private void OnEnable()
    {
        _infoButton.ButtonClicked += OnButtonClicked;
        _generatorButton.ButtonClicked += OnButtonClicked;

        foreach (var button in _exitButton)
            button.ButtonExit += OnButtonExit;
    }

    private void OnDisable()
    {
        _infoButton.ButtonClicked -= OnButtonClicked;
        _generatorButton.ButtonClicked -= OnButtonClicked;

        foreach (var button in _exitButton)
            button.ButtonExit -= OnButtonExit;
    }

    private void OnButtonExit()
    {
        _infoButton.Enable();
        _generatorButton.Enable();
    }

    private void OnButtonClicked()
    {
        _infoButton.Disable();
        _generatorButton.Disable();
    }
}