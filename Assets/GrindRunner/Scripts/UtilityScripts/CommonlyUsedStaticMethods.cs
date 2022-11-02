using UnityEngine;
using UnityEngine.SceneManagement;
namespace GrindRunner.Scripts.UtilityScripts
{
    public static class CommonlyUsedStaticMethods
    {
        /// <summary>
        /// In build - Quits the game
        /// In playmode - Ends the playmode 
        /// </summary>
        public static void QuitGame()
        {
            Debug.Log($"Quitting Game");
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
				Application.Quit();
#endif
        }
        
        /// <summary>
        /// This will reset the current scene.
        /// </summary>
        public static void ResetCurrentScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        /// <summary>
        /// This will a build index to load a scene.
        /// </summary>
        /// <param name="sceneNumber">The build index of the scene you want to load.</param>
        public static void LoadSceneNumber(int sceneNumber)
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}
