using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthWatcher : MonoBehaviour
{
    public CharacterBrain characterBrain;
    public TMPro.TextMeshProUGUI HealthText;

    // Update is called once per frame
    void Update()
    {
       HealthText.text = "Health: " + characterBrain.health.ToString();
    }
}
