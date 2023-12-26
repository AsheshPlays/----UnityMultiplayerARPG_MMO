using Cysharp.Threading.Tasks;

namespace MultiplayerARPG.MMO
{
    public interface IIAPReceiptValidator
    {
        UniTask<IAPReceiptValidateResult> ValidateIAPReceipt(string userId, string characterId, string receipt);
    }
}
