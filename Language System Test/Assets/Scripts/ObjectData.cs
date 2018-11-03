using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LanguageHandling;

[CreateAssetMenu(fileName = "New Object Data", menuName = "Object Data")]
public class ObjectData : ScriptableObject {

    public TextAndAudio[] textAndAudios;
    public TextAndAudio CurrentTextAndAudio
    {
        get
        {
            for (int i = 0; i < textAndAudios.Length; i++)
            {
                if(textAndAudios[i].language == LanguageHandler.Instance.CurrentLanguage)
                {
                    return textAndAudios[i];
                }
            }

            return null;
        }
    }
}
