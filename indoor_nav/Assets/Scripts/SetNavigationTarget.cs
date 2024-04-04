using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField]
    private Camera topDownCamera;
    [SerializeField]
    private GameObject navTarget;

    private NavMeshPath path; // The path to the navigation target
    private LineRenderer lineRenderer; // The line renderer to draw the path

    private bool lineToggle = false; // Toggle to show/hide the path

    private void Start() {
        path = new NavMeshPath();
        lineRenderer = transform.GetComponent<LineRenderer>();
    }

    private void Update() {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began)) {
            lineToggle = !lineToggle;
        }
        if (lineToggle) {
            NavMesh.CalculatePath(transform.position, navTarget.transform.position, NavMesh.AllAreas, path);
            lineRenderer.positionCount = path.corners.Length;
            lineRenderer.SetPositions(path.corners);
            lineRenderer.enabled = true;
        }
    }
}