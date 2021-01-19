using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(WebcamManager))]
public class WebcamManagerEditor : Editor
{
    WebcamManager instance;

    void Start()
    {
        instance = (WebcamManager)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(GUILayout.Button("Use front-facing Camera"))
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType<WebcamManager>();
            instance.Action_useFrontCam(true);
        }
        if (GUILayout.Button("Start front-facing Camera"))
        {
            instance.Action_StartWebcam();
        }
        if (GUILayout.Button("Stop front-facing Camera"))
        {
            instance.Action_StopWebcam();
        }
    }
}
#endif
