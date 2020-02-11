﻿using Ibit.Core.Serial;
using UnityEngine;
using UnityEngine.UI;

namespace Ibit.MainMenu.UI
{
    public class ExtensorStatus : MonoBehaviour
    {
        [SerializeField]
        private SerialControllerCinta serialController;

        [SerializeField]
        private Sprite offline, online;

        private void Awake()
        {
            if (serialController == null)
                serialController = FindObjectOfType<SerialControllerCinta>();

            if (serialController == null)
                Debug.LogWarning("Serial Controller instance not found!");
        }

        private void FixedUpdate() => GetComponent<Image>().sprite = serialController.IsConnected ? online : offline;

        public void Reboot() => UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}