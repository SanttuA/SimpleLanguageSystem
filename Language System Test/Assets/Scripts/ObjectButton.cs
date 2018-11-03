using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectButton : MonoBehaviour {

    [SerializeField]
    private ObjectData myData;

    [SerializeField]
    private Text myText;

    [SerializeField]
    private AudioSource audioSource;

	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        SetMyText();
	}
	
    private void SetMyText()
    {
        myText.text = myData.CurrentTextAndAudio.text;
    }

    public void PlayMyAudio()
    {
        audioSource.clip = myData.CurrentTextAndAudio.audio;
        audioSource.Play();
    }
}
