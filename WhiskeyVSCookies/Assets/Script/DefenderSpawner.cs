using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    public Camera myCamera;
    private GameObject parent;
    private StarDispaly starDispaly;
    private void Start()
    {
        starDispaly = GameObject.FindObjectOfType<StarDispaly>();
        parent = GameObject.Find("Defenders");

        if (!parent)
        {
            parent = new GameObject("Defenders");

        }
    }

    void OnMouseDown()
    {
        Vector2 rawPos = CalculateWorldPointOfMouseClick();
        Vector2 roundedPos = SnapToGrid(rawPos);
        GameObject defender = Button.selectedDefender;
        int defenderCost = defender.GetComponent<Defender>().starCoast;

        if (starDispaly.UseStars(defenderCost) == StarDispaly.Status.SUCCESS)
        {
            Quaternion zeroRot = Quaternion.identity;
            GameObject newDef = Instantiate(defender, roundedPos, zeroRot) as GameObject;
            newDef.transform.parent = parent.transform;
        }
        else
        {
            Debug.Log("Insufficient stars to spawn");
        }

    }
    Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }
    Vector2 CalculateWorldPointOfMouseClick()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);

        return  worldPos;
    }
}
