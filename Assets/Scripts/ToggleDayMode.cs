using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleDayMode : MonoBehaviour
{
    [SerializeField] Light directionalLight;
    [SerializeField] Light diningTableLamp1;
    [SerializeField] Light diningTableLamp2;
    [SerializeField] Light kitchenLamp;
    [SerializeField] Light hallwayLamp;
    [SerializeField] Light bathroomLamp;
    [SerializeField] Light bedroomCeilingLamp;
    [SerializeField] Light bedroomSofaLamp;
    [SerializeField] Light bedroomBedLamp;
    [SerializeField] Material daySkybox;
    [SerializeField] Material nightSkybox;
    [SerializeField] TextMeshProUGUI dayNightButton;
    private bool isDayMode;

    public void ToggleMode()
    {
        directionalLight.color = isDayMode ? Color.blue : Color.white;
        directionalLight.intensity = isDayMode ? 0.5f : 1.4f;
        RenderSettings.skybox = isDayMode ? nightSkybox : daySkybox;
        dayNightButton.text = isDayMode ? "Mode jour" : "Mode nuit";
        diningTableLamp1.gameObject.SetActive(isDayMode);
        diningTableLamp2.gameObject.SetActive(isDayMode);
        kitchenLamp.gameObject.SetActive(isDayMode);
        hallwayLamp.gameObject.SetActive(isDayMode);
        bathroomLamp.gameObject.SetActive(isDayMode);
        bedroomCeilingLamp.gameObject.SetActive(isDayMode);
        bedroomSofaLamp.gameObject.SetActive(isDayMode);
        bedroomBedLamp.gameObject.SetActive(isDayMode);
        isDayMode = !isDayMode;
    }

    void Start()
    {
        isDayMode = true;
        dayNightButton.text = "Mode nuit";
    }
}
