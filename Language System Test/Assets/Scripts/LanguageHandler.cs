using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LanguageHandling
{
    public class LanguageHandler : MonoBehaviour
    {
        public enum Languages { EN, FI, SE };
        [SerializeField]
        private Languages currentLanguage;
        public Languages CurrentLanguage
        {
            get { return currentLanguage; }
            set { currentLanguage = value; }
        }

        private static LanguageHandler instance;
        public static LanguageHandler Instance
        {
            get { return instance; }
        }

        void Awake()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }
    }
}