using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskWaitUntilCanceledExtensionMethods
    {
        public static UniTask WaitUntilCanceled
        (
            this GameObject  self,
            PlayerLoopTiming timing = PlayerLoopTiming.Update
        )
        {
            return UniTask.WaitUntilCanceled
            (
                timing: timing,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask WaitUntilCanceled
        (
            this Component   self,
            PlayerLoopTiming timing = PlayerLoopTiming.Update
        )
        {
            return self.gameObject.WaitUntilCanceled( timing );
        }
    }
}