using UnityEngine;

public class ScenePersist : MonoBehaviour
{
    void Awake()  // this happens before every events 
    {
        int numberOfScenePersists = FindObjectsByType<ScenePersist>(FindObjectsSortMode.None).Length;
        if (numberOfScenePersists > 1)
        {
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    
    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
}
