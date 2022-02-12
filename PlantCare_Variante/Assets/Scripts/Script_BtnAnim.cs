using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_BtnAnim : MonoBehaviour
{
    public GameObject Panel;

    /// <summary>
    /// F�hrt das Burger-Men� mit einer Animation aus und ein.
    /// </summary>
    public void OpenPanel()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");

                animator.SetBool("open", !isOpen);
            }
        }
    }
}
