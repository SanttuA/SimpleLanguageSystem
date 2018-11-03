using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LanguageHandling;

public class LanguageButton : MonoBehaviour {

    [SerializeField]
    private LanguageHandler.Languages targetLanguage;
	
    public void SetCurrentLanguage()
    {
        LanguageHandler.Instance.CurrentLanguage = targetLanguage;
    }
}
