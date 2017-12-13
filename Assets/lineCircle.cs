using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class lineCircle : MonoBehaviour {

    public int resolution = 40;
    public float lineWidh = .5f;
    public float radius;
    public bool fillScreen = false;

    private LineRenderer lineRenderer;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        setupCircle();
    }

    private void setupCircle()
    {

        lineRenderer.widthMultiplier = lineWidh;

        if (fillScreen)
        {
            radius = Vector3.Distance(Camera.main.ScreenToWorldPoint(new Vector3(0f, Camera.main.pixelRect.yMax, 0f)), Camera.main.ScreenToWorldPoint(new Vector3(0f,Camera.main.pixelRect.yMin,0f))) * .5f * lineWidh;
        }

        float deltaTheta = (2f * Mathf.PI) / resolution;
        float theta = 0f;

        lineRenderer.positionCount = resolution;

        
        for (int i = 0; i < lineRenderer.positionCount + 0; i++)
        {
            Vector3 pos = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0);
            lineRenderer.SetPosition(i, pos);
            

            theta += deltaTheta;
        }

    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        float deltaTheta = (2f * Mathf.PI)/resolution ;
        float theta = 0f;

        Vector3 oldPos = Vector3.zero;
        for ( int i = 0; i < resolution + 1; i++)
        {
            Vector3 pos = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0);
            Gizmos.DrawLine(oldPos, transform.position + pos);
            oldPos = transform.position + pos;

            theta += deltaTheta;
        }
    }

#endif


}
