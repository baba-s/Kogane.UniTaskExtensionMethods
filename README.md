# Kogane UniTask Extension Methods

UniTask の拡張メソッド

## 使用例

```cs
using System.Threading;
using Cysharp.Threading.Tasks;
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private async UniTaskVoid Start()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken       = cancellationTokenSource.Token;

        await gameObject.Delay( 1000 );
        await this.Delay( 1000 );

        await gameObject.DelayFrame( 1 );
        await this.DelayFrame( 1 );

        await gameObject.WaitForEndOfFrame( this );
        await this.WaitForEndOfFrame( this );
        await this.WaitForEndOfFrame();

        await gameObject.WaitForFixedUpdate();
        await this.WaitForFixedUpdate();

        await gameObject.WaitUntilCanceled();
        await this.WaitUntilCanceled();

        await gameObject.WaitUntil( () => true );
        await this.WaitUntil( () => true );

        await gameObject.WaitWhile( () => false );
        await this.WaitWhile( () => false );

        await gameObject.Yield();
        await this.Yield();

        await gameObject.NextFrame();
        await gameObject.NextFrame( cancellationToken );
        await this.NextFrame();
        await this.NextFrame( cancellationToken );
    }
}
```