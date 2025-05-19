using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CharacterOne : MonoBehaviour
{
    public Animator animator;
    public string[] animationStateNames;
    private int currentAnimationIndex = 0;
    private bool isDancing = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDancing = true;
            currentAnimationIndex++;
            if (currentAnimationIndex >= animationStateNames.Length)
                currentAnimationIndex = 0;

            animator.SetBool("isDancing", isDancing);
            animator.SetInteger("animationIndex", currentAnimationIndex);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            isDancing = false;
            animator.SetBool("isDancing", isDancing);
        }
    }
}
