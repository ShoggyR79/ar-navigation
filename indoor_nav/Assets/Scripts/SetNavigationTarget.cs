using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown navTargetDropdown;

    [SerializeField]
    private List<Target> navTargets = new List<Target>();

    private NavMeshPath path; // The path to the navigation target
    private LineRenderer lineRenderer; // The line renderer to draw the path

    private Vector3 targetPosition = Vector3.zero; // The position of the navigation target

    private bool lineToggle = false; // Toggle to show/hide the path

    private void Start()
    {
        path = new NavMeshPath();
        lineRenderer = transform.GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
        if (navTargets.Count > 0)
        {
            targetPosition = navTargets[0].PositionObject.transform.position;
        }
    }

    private void Update()
    {
        if (lineToggle && targetPosition != Vector3.zero)
        {
            NavMesh.CalculatePath(transform.position, targetPosition, NavMesh.AllAreas, path);
            lineRenderer.positionCount = path.corners.Length;
            lineRenderer.SetPositions(path.corners);
        }
    }

    public void SetTarget(int index)
    {
        targetPosition = Vector3.zero;
        string targetName = navTargets[index].Name;
        Target cur = navTargets.Find(t => t.Name == (targetName));
        if (cur != null)
        {
            targetPosition = cur.PositionObject.transform.position;
        }
    }

    public void ToggleLine()
    {
        lineToggle = !lineToggle;
        lineRenderer.enabled = lineToggle;
    }
}
