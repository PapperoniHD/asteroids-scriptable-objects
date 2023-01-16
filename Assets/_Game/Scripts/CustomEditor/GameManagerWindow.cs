using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManagerWindow : EditorWindow
{
    [SerializeField] private GameManager m_GameManager;
    
    [MenuItem("Gabriel/Game Editor")]
    static void CreateMenu()
    {
        var window = GetWindow<GameManagerWindow>();
        window.titleContent = new GUIContent("Game Editor");
    }

    public void OnEnable()
    {
        m_GameManager = GameObject.FindGameObjectsWithTag("GameManager").FirstOrDefault()?.GetComponent<GameManager>();
    }

    public void CreateGUI()
    {
        if (m_GameManager == null)
        {
            return;
        }

        var scrollView = new ScrollView() { viewDataKey = "WindowsScrollView" };
        scrollView.Add(new InspectorElement(m_GameManager));
        rootVisualElement.Add(scrollView);
    }
}
