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
    public VisualTreeAsset m_UXML;
    [SerializeField] private GameManager m_GameManager;
    
    [MenuItem("Gabriel/Game Editor")]
    static void CreateMenu()
    {
        var window = GetWindow<GameManagerWindow>();
        window.titleContent = new GUIContent("Game Editor");
        window.minSize = new Vector2(460, 450);
        window.maxSize = new Vector2(460, 450);
    }
    
    public void OnEnable()
    {
        m_UXML ??= AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/GameManagerEditor.uxml");
        m_GameManager ??= Resources.Load<GameManager>("GameManagerSO");

        var gameManagerObj = new SerializedObject(m_GameManager);

        rootVisualElement.Bind(gameManagerObj);

        /*button.clickable.clicked += () =>
        {
            m_GameManager.ResetDefault();
        };*/
    }
    
    
    public void CreateGUI()
    {
        if (m_GameManager == null)
        {
            return;
        }

        var root = new VisualElement();
       // m_UXML ??= AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/GameManagerEditor.uxml");
        rootVisualElement.Add(root);
        if (m_UXML != null) m_UXML.CloneTree(root);

        root.Q<Button>("Default").clicked += m_GameManager.ResetDefault;

        //InspectorElement.FillDefaultInspector(root, serializedObject, this);

        /*var scrollView = new ScrollView() { viewDataKey = "WindowsScrollView" };
        scrollView.Add(new InspectorElement(m_GameManager));
        rootVisualElement.Add(scrollView);*/
        
        
    }
}
