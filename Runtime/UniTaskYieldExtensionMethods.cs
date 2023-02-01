using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskYieldExtensionMethods
    {
        public static UniTask Yield( this GameObject self )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.Yield( self.GetCancellationTokenOnDestroy() );
        }

        public static UniTask Yield( this Component self )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.Yield();
        }

        public static UniTask Yield
        (
            this GameObject  self,
            PlayerLoopTiming timing
        )
        {
            if ( self == null ) throw new OperationCanceledException();

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
            if ( self == null ) throw new OperationCanceledException();

            return Yield( self.gameObject, timing );
        }
    }
}