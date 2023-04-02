#region Copy
// This file is © 2022 Rumyancev Pavel <paulrumyancev@gmail.com>
// Vector. School of Game development
#endregion
using Slots.Models;
using TMPro;
using UnityEngine;

namespace Slots.Gameplay.UI
{
    public class PlayerBalances : MonoBehaviour
    {
        #region Editor

        [SerializeField]
        private PlayerModel _playerModel;

        [SerializeField]
        private TMP_Text _coinsBalance;

        [SerializeField]
        private TMP_Text _gemsBalance;
        
        #endregion
        
        #region Methods

        private void Start()
        {
        }

        private void OnCoinsBalanceChange(int oldBalance, int newBalance)
        {
        }
        
        private void OnGemsBalanceChange(int oldBalance, int newBalance)
        {
        }

        private void UpdateBalances(int coins, int gems)
        {
            _coinsBalance.text = coins.ToString();
            _gemsBalance.text = gems.ToString();
        }

        private void OnDestroy()
        {
            _playerModel.CoinsBalanceChanged -= OnCoinsBalanceChange;
            _playerModel.GemsBalanceChanged -= OnGemsBalanceChange;
        }

        #endregion
    }
}