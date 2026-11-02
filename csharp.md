# C# 学習ノート

## LINQ

Whereは条件で絞り込むために使用する。

```csharp
var adults = people.Where(x => x.Age >= 20);
```

## Event

イベントは通知の仕組み。

```csharp
button1.Click += Button1_Click;
```

## メモ

- delegateを復習する
- eventを復習する
- async/awaitを学習する
