using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskWaitForFixedUpdateExtensionMethods
    {
        public static UniTask WaitForFixedUpdate( this GameObject self )
        {
            if ( self == null ) throw new OperationCanceledException();

            return UniTask.WaitForFixedUpdate( self.GetCancellationTokenOnDestroy() );
        }

        public static UniTask WaitForFixedUpdate( this Component self )
        {
            if ( self == null ) throw new OperationCanceledException();

            return self.gameObject.WaitForFixedUpdate();
        }
    }
}