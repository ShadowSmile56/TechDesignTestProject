using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public Animator animator;
    private bool isAnimating = false;
    private void OnMouseDown()
    {
        // ���� �������� �� ���������������, ��������� �   
        if (!isAnimating)
        {
            animator.SetBool("IsClicked", true);
            isAnimating = true;
        }
        // ���� �������� ���������������, ���������� �
        else
        {
            animator.SetBool("IsClicked", false);
            isAnimating = false;
        }
    }
}