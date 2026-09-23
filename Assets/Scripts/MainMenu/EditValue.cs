using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EditValue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Slider slider;

    void Update()
    {
        text.text = "" + slider.value.ToString("F1");
    }
}
