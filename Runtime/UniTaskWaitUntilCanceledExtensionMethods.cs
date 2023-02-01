using System;
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
            if ( self == null ) throw new OperationCanceledException();

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
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.WaitUntilCanceled( timing );
        }
    }
}