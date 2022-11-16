using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    public Transform paintBrushTip;
    public GameObject paintPrefab;

    private GameObject tempPaintPrefab;
    // Start is called before the first frame update
    

    public void StartPainting()
    {
        tempPaintPrefab = Instantiate(paintPrefab, paintBrushTip.position, paintBrushTip.rotation);
        tempPaintPrefab.transform.SetParent(paintBrushTip);
    }

    public void StopPainting()
    {
        if (tempPaintPrefab != null)
        {
            tempPaintPrefab.transform.SetParent(null);
            tempPaintPrefab = null;
        }
    }
}
