using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class GetCancellationTokenOnDestroyIfNotNullExtensionMethods
    {
        public static CancellationToken GetCancellationTokenOnDestroyIfNotNull( this GameObject self )
        {
            if ( self == null ) throw new OperationCanceledException();
            return self.GetCancellationTokenOnDestroy();
        }

        public static CancellationToken GetCancellationTokenOnDestroyIfNotNull( this Component self )
        {
            if ( self == null ) throw new OperationCanceledException();
            return self.GetCancellationTokenOnDestroy();
        }
    }
}