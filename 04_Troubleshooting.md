## 4. 詰まったところ・トラブルシューティング

### 4.1 レイアウト関連

- **謎の横線が表示される**
  - `AutoScroll` の影響と症状
  - 原因の確認と対処方法
- **横スクロールバーが表示される**
  - コントロールの幅と親コンテナの幅
  - `AutoScroll`、`Dock`、`Anchor` などの設定確認
- **後からメニューを追加時元のパネルがメニューに重なってしまう**

  - 横Dock=Fill と Controls.Add の順序に注意**

WinForms では `Dock` の設定だけでなく、親コントロールへ追加される順序によってレイアウト結果が変わる場合がある。

例えば、フォーム上に `MenuStrip` と `TableLayoutPanel` を配置し、`TableLayoutPanel.Dock = DockStyle.Fill` を設定した場合を考える。

---

#### 問題のある例

```csharp
Controls.Add(menuStrip1);
Controls.Add(tlpRoomControl);
```

この場合、後から追加された `tlpRoomControl` が前面に配置されるため、`MenuStrip` の領域まで使用してしまうことがある。

```text
frmMain
│
├─ MenuStrip
│
└─ TableLayoutPanel (Dock=Fill)
    ↑
    後から追加されたため全面を占有
```

実際の表示イメージ

```text
┌─────────────────────────────┐
│ MenuStrip                   │
│┌───────────────────────────┐│
││ オペ室１                  ││ ← 上部が切れる
││                           ││
││                           ││
│└───────────────────────────┘│
└─────────────────────────────┘
```

発生した現象

- MenuStrip追加後に画面上部が切れる
- PanelがMenuStripに重なる
- Dock=Fillが正しく設定されているように見えても崩れる
- デザイナー上でも位置がおかしく見える場合がある

---

#### 正しい例

```csharp
Controls.Add(tlpRoomControl);
Controls.Add(menuStrip1);
```

この順序にすると、MenuStripが先頭領域を確保し、残り領域へDock=Fillが適用される。

```text
frmMain
│
├─ TableLayoutPanel (Dock=Fill)
│
└─ MenuStrip
```

表示イメージ

```text
┌─────────────────────────────┐
│ MenuStrip                   │
├─────────────────────────────┤
│                             │
│   TableLayoutPanel          │
│                             │
│   ┌─────────┐ ┌─────────┐   │
│   │オペ室１ │ │オペ室２ │   │
│   └─────────┘ └─────────┘   │
│                             │
└─────────────────────────────┘
```

---

#### 今回の学習ポイント

以下の設定が正しくても、

```csharp
tlpRoomControl.Dock = DockStyle.Fill;
```

だけではレイアウトは保証されない。

WinFormsでは次の要素をセットで確認すること。

1. Dock
2. Anchor
3. Margin
4. Padding
5. Controls.Add の順序
6. 親子関係（どのコンテナに所属しているか）

---

#### 実践メモ

今回の画面では、

```csharp
Controls.Add(menuStrip1);
Controls.Add(tlpRoomControl);
```

となっていたため、MenuStrip追加後にオペ室パネルの上部が切れる現象が発生した。

以下へ修正することで解消した。

```csharp
Controls.Add(tlpRoomControl);
Controls.Add(menuStrip1);
```

見た目上は Dock 設定の問題に見えたが、実際の原因は **Controls.Add の追加順序** だった。

これは WinForms のレイアウトで発生しやすい典型的なトラブルの一つである。

### 4.2 入力・操作関連

- **`CheckedListBox` が1回目のクリックでチェックされない**
  - `CheckOnClick = true` に設定する
- **`MaskedTextBox` の入力が遅い**
  - キー入力イベントの処理内容を確認する
  - 不要な処理や時間のかかる処理を見直す
  - 入力制限の為、KeyPlessやKeyUpに制御を入れていたのが原因

---

## 5. C#全般のテクニック

### 5.1 nullの扱い

- **`!`（null免除演算子）**
  - `クラス名!.プロパティ名`
  - nullではないことをコンパイラに伝える
  - 実行時のnullチェックを追加するものではない
  - 業務的にnullがあり得ない場合とかに使用
- **`?.`（null条件演算子）**
  - `クラス名?.プロパティ名`
  - 対象がnullの場合にメンバーアクセスを行わず、結果をnullにする

### 5.2 LINQの活用

- **`Where`**：条件に一致する要素を抽出する
- **`Select`**：要素を別の値や型に変換する
- **`Zip`**：複数のシーケンスから同じ位置の要素を組み合わせる
- **`ForEach`**：各要素に対して処理を実行する
- **効果的な使い分け**
  - 抽出：`Where`
  - 変換：`Select`
  - 対応する要素同士の組み合わせ：`Zip`
  - 各要素への処理：`foreach` 文や `List<T>.ForEach()`

---

## 6. 参照先一覧

| 参照先 | 関連する学習内容 |
|---|---|
| `frmMain` | Panel系コントロールの使い分け |
| `frmMain::frmMain_Shown` | テキストボックスの入力制限 |
| `frmMain` コンストラクタ | ドラッグ＆ドロップの初期設定・`AllowDrop` |
| `ucrTodoPanel` | Todo入力用ユーザーコントロール |
| `CheckedListBox.CheckOnClick` | 1回のクリックでチェックを切り替える設定 |

---

## 7. 今後追加する項目

- [ ] `TableLayoutPanel` と `FlowLayoutPanel` の使い分けの具体例
- [ ] `Dock` と `Anchor` の違いと使い分け
- [ ] `AutoSize` と `AutoSizeMode` の違い
- [ ] LINQの遅延実行と即時実行
- [ ] イベントハンドラーの登録・解除
- [ ] ユーザーコントロール間のデータ受け渡し
- [ ] デザイナーで生成されるコードと通常のコードの役割
