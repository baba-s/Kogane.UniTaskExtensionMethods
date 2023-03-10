using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskWaitWhileExtensionMethods
    {
        public static UniTask WaitWhile
        (
            this GameObject  self,
            Func<bool>       predicate,
            PlayerLoopTiming timing = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.WaitWhile
            (
                predicate: predicate,
                timing: timing,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask WaitWhile
        (
            this Component   self,
            Func<bool>       predicate,
            PlayerLoopTiming timing = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.WaitWhile
            (
                predicate: predicate,
                timing: timing
            );
        }
    }
}