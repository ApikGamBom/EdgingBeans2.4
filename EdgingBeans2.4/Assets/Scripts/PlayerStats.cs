using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public TMP_Text oilCountText;
    public static int oilCount;
    public int publicOilCount;
    void Start()
    {
        oilCount = publicOilCount;
    }

    void Update()
    {

        oilCountText.text = ": " + oilCount.ToString();
    }
}
