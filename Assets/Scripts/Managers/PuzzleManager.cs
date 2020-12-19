using System;

using B2B.Data;

namespace B2B.Managers
{
    public class PuzzleManager<T> : Singleton<T> where T : PuzzleManager<T>
    {
        #region Variables

        #region Public Variables

        public event Action OnPuzzleInit;
        public event Action OnPuzzleStarted;
        public event Action OnPuzzleEnded;

        #endregion

        #region Protected Variables

        protected string ResourcesFolderSuffix;

        #endregion

        #endregion

        #region Public Methods

        public virtual void InitPuzzle(Picture picture)
        {
            OnPuzzleInit?.Invoke();
        }

        public virtual void StartPuzzle(Picture picture)
        {
            OnPuzzleStarted?.Invoke();
        }

        public virtual void EndPuzzle()
        {
            OnPuzzleEnded?.Invoke();
        }

        #endregion
    }
}
