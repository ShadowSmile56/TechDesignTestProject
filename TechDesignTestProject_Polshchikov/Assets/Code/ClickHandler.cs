using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public Animator animator;
    private bool isAnimating = false;
    private void OnMouseDown()
    {
        // Если анимация не воспроизводится, запустите её   
        if (!isAnimating)
        {
            animator.SetBool("IsClicked", true);
            isAnimating = true;
        }
        // Если анимация воспроизводится, остановите её
        else
        {
            animator.SetBool("IsClicked", false);
            isAnimating = false;
        }
    }
}