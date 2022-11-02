using GrindRunner.Scripts.UtilityScripts;
using UnityEngine;

namespace GrindRunner.Scripts.Menus
{
    public class MainMenuManager : MonoBehaviour
    {
        public void StartAngelWithShotgun()
        {
            CommonlyUsedStaticMethods.LoadSceneNumber(1);
        }
    }
}
