using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskWaitForEndOfFrameExtensionMethods
    {
        public static UniTask WaitForEndOfFrame
        (
            this GameObject self,
            MonoBehaviour   coroutineRunner
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.WaitForEndOfFrame
            (
                coroutineRunner,
                self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask WaitForEndOfFrame
        (
            this Component self,
            MonoBehaviour  coroutineRunner
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.WaitForEndOfFrame( coroutineRunner );
        }

        public static UniTask WaitForEndOfFrame( this MonoBehaviour self )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.WaitForEndOfFrame( self );
        }
    }
}