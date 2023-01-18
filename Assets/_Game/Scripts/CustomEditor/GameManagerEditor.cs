using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomEditor(typeof(GameManager))]
public class GameManagerEditor : Editor
{
    public VisualTreeAsset m_UXML;
    
    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();
        m_UXML = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/GameManagerEditor.uxml");
        if (m_UXML != null) m_UXML.CloneTree(root);

        

        InspectorElement.FillDefaultInspector(root, serializedObject, this);
        
        return root;
    }


    private void OnEnable()
    {

    }
}
