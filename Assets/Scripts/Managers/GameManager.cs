using System.Collections.Generic;
using UnityEngine;
using System;

using B2B.Contracts;
using B2B.StateManagement.ErrorHandling;

namespace B2B.Managers
{
    [RequireComponent(typeof(Animator))]
    public sealed class GameManager : Singleton<GameManager>, IStateMachine<GameManager.States>
    {
        #region Variables

        #region Public Variables

        public enum States
        {
            GameSetup,
            MainMenuLayer,
            Register,
            MainMenu,
            Options,
            Credits,
            Profile,
            Achievements,
            GameplayLayer,
            Gameplay,
            Pause,
            LevelFailed,
            LevelCompleted,
        }

        public States CurrentState { get; private set; }

        #endregion

        #region Private Variables

        private Animator _animator;

        private readonly Dictionary<States, string> _animatorTriggers = new Dictionary<States, string>
        {
            { States.MainMenuLayer, "GoToMainMenuLayer"},
            { States.Register, "GoToRegister"},
            { States.MainMenu, "GoToMainMenu" },
            { States.Options, "GoToOptions"},
            { States.Credits, "GoToCredits"},
            { States.Profile, "GoToProfile"},
            { States.Achievements, "GoToAchievements"},
            { States.GameplayLayer, "GoToGameplayLayer"},
            { States.Gameplay, "GoToGameplay"},
            { States.Pause, "GoToPause"},
            { States.LevelFailed, "GoToLevelFailed"},
            { States.LevelCompleted, "GoToLevelCompleted"}
        };

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
