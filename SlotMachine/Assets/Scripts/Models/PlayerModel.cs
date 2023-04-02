#region Copy
// This file is © 2022 Rumyancev Pavel <paulrumyancev@gmail.com>
// Vector. School of Game development
#endregion

using System;
using UnityEngine;

namespace Slots.Models
{
    [CreateAssetMenu(menuName = "Models/Player Model", fileName = "Player Model")]
    public class PlayerModel : ScriptableObject
    {
        #region Events

        public event Action<int, int> CoinsBalanceChanged;
        
        public event Action<int, int> GemsBalanceChanged;
        
        #endregion
        
        #region Editor

        [SerializeField]
        private int _coinsBalance;

        [SerializeField]
        private int _gemsBalance;
        
        #endregion

        #region Methods

        public void AddCoins(int coinsToAdd)
        {
            var oldBalance = _coinsBalance;
            _coinsBalance += coinsToAdd;
            CoinsBalanceChanged?.Invoke(oldBalance, _coinsBalance);
        }

        public bool WithdrawCoins(int coinsToWithdraw)
        {
            if (coinsToWithdraw > _coinsBalance)
            {
                return false;
            }

            var oldBalance = _coinsBalance;
            _coinsBalance -= coinsToWithdraw;
            CoinsBalanceChanged?.Invoke(oldBalance, _coinsBalance);
            return true;
        }

        public void AddGems(int gemsToAdd)
        {
            var oldBalance = _gemsBalance;
            _gemsBalance += gemsToAdd;
            GemsBalanceChanged?.Invoke(oldBalance, _gemsBalance);
        }

        public bool WithdrawGems(int gemsToWithdraw)
        {
            if (gemsToWithdraw > _gemsBalance)
            {
                return false;
            }
            var oldBalance = _gemsBalance;
            _gemsBalance -= gemsToWithdraw;
            GemsBalanceChanged?.Invoke(oldBalance, _gemsBalance);
            return true;
        }

        #endregion
        
        #region Properties

        public int CoinsBalance => _coinsBalance;

        public int GemsBalance => _gemsBalance;

        #endregion
    }
}