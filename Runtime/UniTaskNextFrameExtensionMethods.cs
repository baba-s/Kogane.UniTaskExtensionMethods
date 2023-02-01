using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskNextFrameExtensionMethods
    {
        public static UniTask NextFrame( this GameObject self )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.NextFrame( self.GetCancellationTokenOnDestroy() );
        }

        public static UniTask NextFrame( this Component self )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.NextFrame();
        }

        public static async UniTask NextFrame
        (
            this GameObject  self,
            PlayerLoopTiming timing
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            await UniTask.NextFrame
            (
                timing: timing,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static async UniTask NextFrame
        (
            this Component   self,
            PlayerLoopTiming timing
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            await self.gameObject.NextFrame( timing );
        }

        public static UniTask NextFrame
        (
            this GameObject   self,
            CancellationToken cancellationToken
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            var cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource
            (
                cancellationToken,
                self.GetCancellationTokenOnDestroy()
            );

            return UniTask.NextFrame( cancellationTokenSource.Token );
        }

        public static UniTask NextFrame
        (
            this Component    self,
            CancellationToken cancellationToken
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.NextFrame( cancellationToken );
        }
    }
}