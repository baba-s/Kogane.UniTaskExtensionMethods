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
            return self.gameObject.WaitForEndOfFrame( coroutineRunner );
        }

        public static UniTask WaitForEndOfFrame( this MonoBehaviour self )
        {
            return self.WaitForEndOfFrame( self );
        }
    }
}