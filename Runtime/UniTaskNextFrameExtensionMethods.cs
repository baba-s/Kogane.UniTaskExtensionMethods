using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskNextFrameExtensionMethods
    {
        public static UniTask NextFrame( this GameObject self )
        {
            return UniTask.NextFrame( self.GetCancellationTokenOnDestroy() );
        }

        public static UniTask NextFrame( this Component self )
        {
            return self.gameObject.NextFrame();
        }

        public static async UniTask NextFrame
        (
            this GameObject  self,
            PlayerLoopTiming timing
        )
        {
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
            await self.gameObject.NextFrame( timing );
        }

        public static UniTask NextFrame
        (
            this GameObject   self,
            CancellationToken cancellationToken
        )
        {
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
            return self.gameObject.NextFrame( cancellationToken );
        }
    }
}