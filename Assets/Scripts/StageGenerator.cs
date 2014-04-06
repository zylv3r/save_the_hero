using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StageGenerator : MonoBehaviour {
    private enum WindowItemType
    {
        None = 0,
        NormalWindow,
        SpikeWindow
    }

    private class StageConfiguration
    {
        public WindowItemType[,] WindowMatrix { get; set; }
    }

    private List<StageConfiguration> _configurations = new List<StageConfiguration>();

    public StageGenerator()
    {
        StageConfiguration one = new StageConfiguration();
        one.WindowMatrix = new WindowItemType[5,6];
        one.WindowMatrix[0, 0] = WindowItemType.NormalWindow;
        one.WindowMatrix[3, 3] = WindowItemType.NormalWindow;
        one.WindowMatrix[4, 5] = WindowItemType.NormalWindow;
        _configurations.Add(one);

        StageConfiguration two = new StageConfiguration();
        two.WindowMatrix = new WindowItemType[5, 6];
        two.WindowMatrix[2, 4] = WindowItemType.NormalWindow;
        two.WindowMatrix[2, 2] = WindowItemType.NormalWindow;
        two.WindowMatrix[1, 0] = WindowItemType.NormalWindow;
        _configurations.Add(two);

        StageConfiguration three = new StageConfiguration();
        three.WindowMatrix = new WindowItemType[5, 6];
        three.WindowMatrix[4, 4] = WindowItemType.NormalWindow;
        three.WindowMatrix[1, 1] = WindowItemType.NormalWindow;
        three.WindowMatrix[2, 5] = WindowItemType.NormalWindow;
        _configurations.Add(three);
    }

	void Awake () {

	}
	
	void Update () {
	
	}

    public void GenerateStage()
    {
        int index = Random.Range(0, _configurations.Count);
        
        StageConfiguration config = _configurations[index];
        
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                WindowItemType itemType = config.WindowMatrix[j,i];
                string name = "Window_" + i + "_" + j;
                Transform child = transform.FindChild(name);
                //print(name);
                if (!child)
                {
                    print("wrong index");
                }
                else
                {
                    switch (itemType)
                    {
                        case WindowItemType.None:
                            child.gameObject.SetActive(false);
                            break;
                        case WindowItemType.NormalWindow:
                            child.gameObject.SetActive(true);
                            break;
                        case WindowItemType.SpikeWindow:
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
