using TMPro;
using UnityEngine;

public class RandomEyesButton : ButtonAbstract
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private EyeMenu _eyeMenu;

    protected override void OnButtonClick()
    {
        _text.text = _eyeMenu.GetEyeText();
    }
}