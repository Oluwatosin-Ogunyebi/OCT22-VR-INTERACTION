using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    public Transform paintBrushTip;
    public GameObject paintPrefab;

    private GameObject tempPaintPrefab;
    private Material tempMaterial;
    // Start is called before the first frame update
    

    public void StartPainting()
    {
        tempPaintPrefab = Instantiate(paintPrefab, paintBrushTip.position, paintBrushTip.rotation);
        tempPaintPrefab.transform.SetParent(paintBrushTip);

        if (tempMaterial != null)
        {
            tempPaintPrefab.GetComponent<TrailRenderer>().material = tempMaterial;
        }

    }

    public void StopPainting()
    {
        if (tempPaintPrefab != null)
        {
            tempPaintPrefab.transform.SetParent(null);
            tempPaintPrefab = null;
        }
    }


    private void OnTriggerEnter(Collider objectHit)
    {
        if (objectHit.gameObject.CompareTag("Paint"))
        {
            tempMaterial = objectHit.gameObject.GetComponent<MeshRenderer>().material;
            paintBrushTip.gameObject.GetComponent<MeshRenderer>().material = tempMaterial;
        }
    }
}
