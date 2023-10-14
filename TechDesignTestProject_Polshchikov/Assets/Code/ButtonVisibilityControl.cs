using UnityEngine;
using UnityEngine.UI;

public class ButtonVisibilityControl : MonoBehaviour
{
    public Button uiButton; // ������ �� ���� UI ������

    private void Start()
    {
        // �� ��������� �������� ������
        HideButton();
    }
    private void OnMouseDown()
    {
        if (uiButton != null)
        {
            // ���� ������ ������, ������ �, ����� ��������
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
        // �������� ������
        uiButton.gameObject.SetActive(true);
    }

    private void HideButton()
    {
        // ��������� ������
        uiButton.gameObject.SetActive(false);
    }
}
