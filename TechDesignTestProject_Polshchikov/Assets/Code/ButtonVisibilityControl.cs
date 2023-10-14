using UnityEngine;
using UnityEngine.UI;

public class ButtonVisibilityControl : MonoBehaviour
{
    public Button uiButton; // Ссылка на вашу UI кнопку

    private void Start()
    {
        // По умолчанию скрываем кнопку
        HideButton();
    }
    private void OnMouseDown()
    {
        if (uiButton != null)
        {
            // Если кнопка видима, скрыть её, иначе показать
            if (uiButton.IsActive())
            {
                HideButton();
            }
            else
            {
                ShowButton();
            }
        }
    }

    private void ShowButton()
    {
        // Включить кнопку
        uiButton.gameObject.SetActive(true);
    }

    private void HideButton()
    {
        // Отключить кнопку
        uiButton.gameObject.SetActive(false);
    }
}
