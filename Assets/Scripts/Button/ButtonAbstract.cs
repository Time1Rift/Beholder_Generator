using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonAbstract : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }

    public void Enable() => _button.interactable = true;

    public void Disable() => _button.interactable = false;

    protected abstract void OnButtonClick();
}