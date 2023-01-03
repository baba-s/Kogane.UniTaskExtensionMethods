using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskWaitUntilValueChangedExtensionMethods
    {
        public static UniTask<U> WaitUntilValueChanged<T, U>
        (
            this GameObject      self,
            T                    target,
            Func<T, U>           monitorFunction,
            PlayerLoopTiming     monitorTiming    = PlayerLoopTiming.Update,
            IEqualityComparer<U> equalityComparer = null
        ) where T : class
        {
            return UniTask.WaitUntilValueChanged
            (
                target: target,
                monitorFunction: monitorFunction,
                monitorTiming: monitorTiming,
                equalityComparer: equalityComparer,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask<U> WaitUntilValueChanged<T, U>
        (
            this Component       self,
            T                    target,
            Func<T, U>           monitorFunction,
            PlayerLoopTiming     monitorTiming    = PlayerLoopTiming.Update,
            IEqualityComparer<U> equalityComparer = null
        ) where T : class
        {
            return self.gameObject.WaitUntilValueChanged
            (
                target: target,
                monitorFunction: monitorFunction,
                monitorTiming: monitorTiming,
                equalityComparer: equalityComparer
            );
        }
    }
}