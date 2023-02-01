using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskDelayExtensionMethods
    {
        public static UniTask Delay
        (
            this GameObject  self,
            int              millisecondsDelay,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.Delay
            (
                millisecondsDelay: millisecondsDelay,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask Delay
        (
            this Component   self,
            int              millisecondsDelay,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.Delay
            (
                millisecondsDelay: millisecondsDelay,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming
            );
        }

        public static UniTask Delay
        (
            this GameObject  self,
            TimeSpan         delayTimeSpan,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.Delay
            (
                delayTimeSpan: delayTimeSpan,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask Delay
        (
            this Component   self,
            TimeSpan         delayTimeSpan,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.Delay
            (
                delayTimeSpan: delayTimeSpan,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming
            );
        }

        public static UniTask Delay
        (
            this GameObject  self,
            int              millisecondsDelay,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.Delay
            (
                millisecondsDelay: millisecondsDelay,
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask Delay
        (
            this Component   self,
            int              millisecondsDelay,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.Delay
            (
                millisecondsDelay: millisecondsDelay,
                delayType: delayType,
                delayTiming: delayTiming
            );
        }

        public static UniTask Delay
        (
            this GameObject  self,
            TimeSpan         delayTimeSpan,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.Delay
            (
                delayTimeSpan: delayTimeSpan,
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: self.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask Delay
        (
            this Component   self,
            TimeSpan         delayTimeSpan,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.Delay
            (
                delayTimeSpan: delayTimeSpan,
                delayType: delayType,
                delayTiming: delayTiming
            );
        }
    }
}