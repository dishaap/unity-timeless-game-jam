using UnityEngine;

namespace MagicPigGames.ProjectileFactory.Demo
{
    public class TestDebugLogger : MonoBehaviour
    {
        private string _defaultMessage = "Test Debug Logger: Hello, World!";
        
        public void DefaultMessage() => LogMessage(_defaultMessage);

        public void LogMessage(string message)
        {
            Debug.Log(message);
        }
    }
}