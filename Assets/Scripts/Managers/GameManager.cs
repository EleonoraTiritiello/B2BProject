using System.Collections.Generic;
using UnityEngine;
using System;

using B2B.Contracts;
using B2B.StateManagement.ErrorHandling;

namespace B2B.Managers
{
    /// <summary>
    /// Class <c> GameManager </c> manages all those tasks that are not the responsibility of the other scripts
    /// </summary>
    [RequireComponent(typeof(Animator))]
    public sealed class GameManager : Singleton<GameManager>, IStateMachine<GameManager.States>
    {
        #region Variables

        #region Public Variables

        /// <summary>
        /// The game states
        /// </summary>
        public enum States
        {
            GameSetup,
            MainMenuLayer,
            Register,
            MainMenu,
            QRCodeScanner,
            Achievements,
            Profile,
            Shop,
            GameInfo,
            GameplayLayer,
            Gameplay,
            Pause,
            PuzzleMode,
            InfoMode,
            LevelCompleted,
        }

        /// <summary>
        /// The current game state
        /// </summary>
        public States CurrentState { get; private set; }

        #endregion

        #region Private Variables

        /// <summary>
        /// The component with which the state machine is implemented
        /// </summary>
        private Animator _animator;

        /// <summary>
        /// A dictionary that relates a state and its corresponding trigger in the animator
        /// </summary>
        private readonly Dictionary<States, string> _animatorTriggers = new Dictionary<States, string>
        {
            { States.MainMenuLayer, "GoToMainMenuLayer"},
            { States.Register, "GoToRegister"},
            { States.MainMenu, "GoToMainMenu" },
            { States.QRCodeScanner, "GoToQRCodeScanner"},
            { States.Achievements, "GoToAchievements"},
            { States.Profile, "GoToProfile"},
            { States.Shop, "GoToShop"},
            { States.GameInfo, "GoToGameInfo"},
            { States.GameplayLayer, "GoToGameplayLayer"},
            { States.Gameplay, "GoToGameplay"},
            { States.Pause, "GoToPause"},
            { States.PuzzleMode, "GoToPuzzleMode"},
            { States.InfoMode, "GoToInfoMode"},
            { States.LevelCompleted, "GoToLevelCompleted"}
        };

        /// <summary>
        /// An event that is called when a change of state occurs
        /// </summary>
        public event Action<States> OnStateChanged;

        #endregion

        #endregion

        #region Unity Callbacks

        private void Awake()
        {
            if (_animator == null) _animator = GetComponent<Animator>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Change the game state
        /// </summary>
        /// <param name="state"> The state that needs to be set </param>
        public void ChangeState(States state)
        {
            if (!_animatorTriggers.ContainsKey(state))
                throw new StateNotFoundException($"No trigger was found on object '{name}' leading to state '{state}'");

            _animator.SetTrigger(_animatorTriggers[state]);

            CurrentState = state;

            OnStateChanged?.Invoke(state);
        }

        #endregion
    }
}
