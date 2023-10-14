using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization.Scripts;

public class Localization : MonoBehaviour
{
    private void Awake()
    {
        LocalizationManager.Read();
        //  LocalizationManager.Language = "Russian";

        switch (Application.systemLanguage)
        {
            case SystemLanguage.English:
                LocalizationManager.Language = "English";
                break;
            case SystemLanguage.Spanish:
                LocalizationManager.Language = "Spanish";
                break;
            case SystemLanguage.Russian:
                LocalizationManager.Language = "Russian";
                break;
        }
    }
}
