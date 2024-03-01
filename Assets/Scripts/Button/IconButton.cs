using System;
using TMPro;

public class IconButton : ButtonAbstract
{
    private TextMeshProUGUI _text;
    private Eye _eye;

    public event Action<IconButton> ButtonClicked;

    private void Awake()
    {
        _text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetEye(Eye eye)
    {
        _eye = eye;
        _text.text = _eye.Name;
    }

    public string GetText() => _eye.Text;

    protected override void OnButtonClick()
    {
        ButtonClicked?.Invoke(this);
    }
}