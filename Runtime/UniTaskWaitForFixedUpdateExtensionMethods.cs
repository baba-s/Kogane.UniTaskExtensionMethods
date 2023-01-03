using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskWaitForFixedUpdateExtensionMethods
    {
        public static UniTask WaitForFixedUpdate( this GameObject self )
        {
            return UniTask.WaitForFixedUpdate( self.GetCancellationTokenOnDestroy() );
        }

        public static UniTask WaitForFixedUpdate( this Component self )
        {
            return self.gameObject.WaitForFixedUpdate();
        }
    }
}