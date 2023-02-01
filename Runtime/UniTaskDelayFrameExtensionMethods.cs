using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskDelayFrameExtensionMethods
    {
        public static UniTask DelayFrame
        (
            this GameObject  self,
            int              delayFrameCount,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.DelayFrame
            (
                delayFrameCount: delayFrameCount,
                delayTiming: delayTiming,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask DelayFrame
        (
            this Component   self,
            int              delayFrameCount,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.DelayFrame
            (
                delayFrameCount: delayFrameCount,
                delayTiming: delayTiming
            );
        }
    }
}