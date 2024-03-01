using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EyeMenu : MonoBehaviour
{
    [SerializeField] private Transform _container;
    [SerializeField] private IconButton _iconButtonPrefab;
    [SerializeField] private TextMeshProUGUI _text;

    private List<IconButton> _iconButtons = new();
    private int _index;

    private void OnDisable()
    {
        if(_iconButtons.Count > 0)
            foreach(var item in _iconButtons)
                item.ButtonClicked -= OnButtonClicked;

        _iconButtons.Clear();
    }

    public string GetEyeText()
    {
        int index = Random.Range(1, _iconButtons.Count);

        while(index == _index)
            index = Random.Range(1, _iconButtons.Count);

        _index = index;

        return _iconButtons[index].GetText();
    }
    public void SetNumber(int number)
    {
        for (int i = 0; i < number; i++)
            _iconButtons.Add(Instantiate(_iconButtonPrefab, _container));
    }

    public void SetEyes(List<Eye> eyes)
    {
        for (int i = 0; i < _iconButtons.Count; i++)
        {
            _iconButtons[i].SetEye(eyes[i]);
            _iconButtons[i].ButtonClicked += OnButtonClicked;
        }

        _text.text = _iconButtons[0].GetText();
    }

    private void OnButtonClicked(IconButton icon) => _text.text = icon.GetText();
}