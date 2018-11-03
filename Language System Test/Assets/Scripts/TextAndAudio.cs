using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LanguageHandling.LanguageHandler;

[CreateAssetMenu(fileName = "New Text and Audio", menuName = "Text and Audio")]
public class TextAndAudio : ScriptableObject {

    public Languages language;
    public string text;
    public AudioClip audio;
}
