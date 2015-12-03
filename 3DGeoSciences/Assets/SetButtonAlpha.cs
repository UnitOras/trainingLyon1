using UnityEngine;
using System.Collections;

public class SetButtonAlpha : MonoBehaviour
{
	public void SetAplpha (float alpha)
    {
        Color newColor = GetComponent<UnityEngine.UI.Image>().color;
        newColor.a = alpha;
        GetComponent<UnityEngine.UI.Image>().color = newColor;
    }
}