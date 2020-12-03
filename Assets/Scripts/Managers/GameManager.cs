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
            Options,
            Credit,
            Profile,
            Achievements,
            GameplayLayer,
            Gameplay,
            Pause,
            LevelFailed,
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
            { States.Options, "GoToOptions"},
            { States.Credit, "GoToCredit"},
            { States.Profile, "GoToProfile"},
            { States.Achievements, "GoToAchievements"},
            { States.GameplayLayer, "GoToGameplayLayer"},
            { States.Gameplay, "GoToGameplay"},
            { States.Pause, "GoToPause"},
            { States.LevelFailed, "GoToLevelFailed"},
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
