using UnityEngine;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        private GameFlowManager flowManager;
        void Start() => flowManager = FindObjectOfType<GameFlowManager>();
        public string TurnInputName = "Horizontal";
        public string AccelerateButtonName = "Accelerate";
        public string BrakeButtonName = "Brake";

        public float sensitivity = 1;
        public override InputData GenerateInput() {
            return new InputData
            {
                Accelerate = Input.GetButton(AccelerateButtonName),
                Brake = flowManager.braking == -1 ? true : false,
                TurnInput = Input.acceleration.x*sensitivity
            };
        }
    }
}
