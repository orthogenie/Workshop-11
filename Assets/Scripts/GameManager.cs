using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance; 

    public float Score { get; private set; }

    private void Awake() {
        if (Instance != null) {
            Debug.LogWarning("Multiple GameManagers, destroying one");
            Destroy(gameObject);
        } else {
            Instance = this;
        }
    }

    public void AddScore(float add) {
        Score += add;
    }

}
