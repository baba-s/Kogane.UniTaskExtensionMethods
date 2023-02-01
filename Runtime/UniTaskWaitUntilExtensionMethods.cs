using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskWaitUntilExtensionMethods
    {
        public static UniTask WaitUntil
        (
            this GameObject  self,
            Func<bool>       predicate,
            PlayerLoopTiming timing = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.WaitUntil
            (
                predicate: predicate,
                timing: timing,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask WaitUntil
        (
            this Component   self,
            Func<bool>       predicate,
            PlayerLoopTiming timing = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.WaitUntil
            (
                predicate: predicate,
                timing: timing
            );
        }
    }
}