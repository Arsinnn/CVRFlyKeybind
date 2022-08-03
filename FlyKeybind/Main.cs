using ABI_RC.Systems.MovementSystem;
using MelonLoader;
using UnityEngine;

namespace FlyKeybind
{
    public class Main : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F))
            {
                MovementSystem.Instance.canFly = true;
                MovementSystem.Instance.ToggleFlight();
            }

        }
    }
}
