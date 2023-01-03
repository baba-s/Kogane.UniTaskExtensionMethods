using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskYieldExtensionMethods
    {
        public static UniTask Yield( this GameObject self )
        {
            return UniTask.Yield( self.GetCancellationTokenOnDestroy() );
        }

        public static UniTask Yield( this Component self )
        {
            return self.gameObject.Yield();
        }

        public static UniTask Yield
        (
            this GameObject  self,
            PlayerLoopTiming timing
        )
        {
            return UniTask.Yield
            (
                timing: timing,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask Yield
        (
            this Component   self,
            PlayerLoopTiming timing
        )
        {
            return Yield( self.gameObject, timing );
        }
    }
}