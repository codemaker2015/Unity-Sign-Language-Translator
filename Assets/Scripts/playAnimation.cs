using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField]  
    Animator anim;
    [SerializeField]  
    Dropdown dropdown;

    public void Start() {
        LoadClipNames();
    }

    public void Update() {
    
    }

    public void LoadClipNames() {
        List<string> names = new List<string>();
        dropdown.ClearOptions();
        foreach (AnimationClip clip in anim.runtimeAnimatorController.animationClips)
            names.Add(clip.name);
        dropdown.AddOptions(names);
    }
    
    public void PlayWord() {
        anim.runtimeAnimatorController = Resources.Load("animController") as RuntimeAnimatorController;
        string name = dropdown.options[dropdown.value].text;
        anim.Play(name);
    }
}
