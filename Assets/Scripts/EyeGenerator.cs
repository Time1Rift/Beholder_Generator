using System.Collections.Generic;
using UnityEngine;

public class EyeGenerator : MonoBehaviour
{
    [SerializeField] private GeneratorButton _generatorButton;
    [SerializeField] private List<Eyes> _eyesList;
    [SerializeField] private EyeMenu _eyeMenu;

    private List<Eye> _eyes = new();

    private void Awake()
    {
        _eyeMenu.SetNumber(_eyesList.Count);
    }

    private void OnEnable()
    {
        _generatorButton.ButtonClicked += OnButtonClicked;
    }

    private void OnDisable()
    {
        _generatorButton.ButtonClicked -= OnButtonClicked;
    }

    private void OnButtonClicked()
    {
        _eyes.Clear();

        for (int i = 0; i < _eyesList.Count; i++)
            _eyes.Add(_eyesList[i].GetEye());

        _eyeMenu.SetEyes(_eyes);
    }
}