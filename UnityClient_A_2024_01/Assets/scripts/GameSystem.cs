using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;
using UnityEngine.UI;
using TMPro;

namespace STORYGAME
{
    UNITY_EDITOR
    [CustomEditor(typeof(GameSystem))]

    public class GameSystemEditor : Editor

    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();
        {
            BaseShaderGUI.OnInspectorGUI();

            GameSystem gameSystem = (GameSystem)target;

            if (GUILayout.Button("Reset Stroy Models"))
            {
                gameSystem.ResetStoryModels();
            }

        }

        if (GUILayout.Button("Assing Text Component by Name"))
        {
            GameObject textObject = GameObject.Find("StroyTextUI");
            if (textObject !=null)
            {
                GameSystem.textComponent = textComponent;
                Debug.Log("Text Componet assigned Succesfully");
            }
        }

    }
}

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance;
    public Text textComponent = null;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        StartCoroutine(ShowText());
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) Storyshow(1);
        if (Input.GetKeyDown(KeyCode.W)) Storyshow(2);
        if (Input.GetKeyDown(KeyCode.E)) Storyshow(3);
    }

    public void Storyshow(int number)
    {
        currentModeIs = FindStoryMode I(number);
        StartCoroutine(ShowText());
    }
    StoryTableObject FindStoryMode I(int number)
    {
        StoryTableObject tempStoryModels = null;
        for(int i=0; i < storyModels.Length; i++)
        {
            if (storyModels[i].storyNumber == number)
            {
                tempStoryModels = storyModels[i];
                break;
            }
        }
    }
    public StoryTableObject[] storyModels;

#if UNITY_EDITOR
    [ContextMenu("Reset Story Models")]

    public void ResetStoryModels()
    {
        storyModels = Resources.LoadAII<StoryTableObject>("");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetstoryModels()
    {
        
    }
}
