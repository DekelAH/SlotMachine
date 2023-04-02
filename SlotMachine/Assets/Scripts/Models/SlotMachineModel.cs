#region Copy
// This file is © 2022 Rumyancev Pavel <paulrumyancev@gmail.com>
// Vector. School of Game development
#endregion

using UnityEngine;

namespace Slots.Models
{
	[CreateAssetMenu(menuName = "Models/Slot Machine Model", fileName = "Slot Machine Model")]
	public class SlotMachineModel : ScriptableObject
	{
		[SerializeField]
		private int _spinPrice;

		public int SpinPrice => _spinPrice;
	}
}