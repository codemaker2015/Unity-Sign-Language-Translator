using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playAnimation : MonoBehaviour
{
    [SerializeField]  
    Animator anim;
    [SerializeField]  
    Dropdown dropdown;

    public void Update() {
    
    }
    
    public void PlayWord() {
        anim.runtimeAnimatorController = Resources.Load("animController") as RuntimeAnimatorController;
        string name = dropdown.options[dropdown.value].text;
        anim.Play(name);
    }
}
