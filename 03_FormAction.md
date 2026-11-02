### 3. 画面動作のテクニック

#### 3.1 テキストボックスの入力制限

特定の文字や形式のみ入力可能にする。

##### 主なイベント

| イベント | 用途 |
|-----------|-----------|
| KeyPress | 入力可能文字の制限 |
| KeyDown | BackSpace、Delete等の制御 |
| KeyUp | 入力後の補正処理 |
| TextChanged | 文字列変更時の処理 |
| Validating | 入力チェック |
| Validated | 入力チェック後の処理 |

##### 主なプロパティ

| プロパティ | 設定例 |
|-----------|-----------|
| CharacterCasing | Upper |
| MaxLength | 7 |
| Text | F-00001 |
| SelectionStart | カーソル位置 |
| SelectionLength | 選択文字数 |

##### 対象コントロール

- TextBox
- MaskedTextBox

---

#### 3.2 ユーザーコントロールの作成

再利用可能な画面部品を作成する。

##### 主なイベント

| イベント | 用途 |
|-----------|-----------|
| Load | 初期化処理 |
| Click | 選択処理 |
| Paint | 描画処理 |
| Resize | サイズ変更時処理 |

##### 主なプロパティ

| プロパティ | 設定例 |
|-----------|-----------|
| Name | ucrTodoPanel |
| Dock | Top / Fill |
| Anchor | Top, Left, Right |
| Tag | 識別用情報 |
| AutoSize | true |

##### よく作成するメンバー

```csharp
public string PatientId { get; set; }

public bool IsSelected { get; set; }
```

---

#### 3.3 ドラッグ＆ドロップ

コントロールやデータを移動する。

##### 主なイベント

| イベント | 用途 |
|-----------|-----------|
| MouseDown | ドラッグ開始 |
| DragEnter | ドロップ可否判定 |
| DragOver | ドラッグ中処理 |
| DragDrop | ドロップ処理 |

##### 主なプロパティ

| プロパティ | 設定例 |
|-----------|-----------|
| AllowDrop | true |
| Location | 配置位置 |
| Left | X座標 |
| Top | Y座標 |

---

#### 3.4 画面サイズ変更への対応

フォームのサイズ変更に合わせてコントロールを再配置する。

##### 主なイベント

| イベント | 用途 |
|-----------|-----------|
| Resize | サイズ変更 |
| SizeChanged | サイズ変更 |
| Layout | レイアウト再計算 |

##### 主なプロパティ

| プロパティ | 設定例 |
|-----------|-----------|
| Dock | Fill |
| Anchor | Top, Left, Right |
| Width | 横サイズ |
| Height | 縦サイズ |
| ClientSize | クライアント領域 |

---

#### 3.5 複数あるユーザーコントロールの選択

配置済みコントロールを検索・操作する。

##### 主なプロパティ

| プロパティ | 用途 |
|-----------|-----------|
| Tag | 識別情報 |
| Name | コントロール名 |
| Controls | 子コントロール管理 |

##### 主なクラス

```csharp
List<UserControl>
List<ucrTodoPanel>
```

##### よく使用するLINQ

```csharp
Where()
FirstOrDefault()
SingleOrDefault()
Select()
ForEach()
```

---

#### 3.6 サイズ変更可能なユーザーコントロール

マウス操作で高さや幅を変更する。

##### 主なイベント

| イベント | 用途 |
|-----------|-----------|
| MouseDown | サイズ変更開始 |
| MouseMove | サイズ変更中 |
| MouseUp | サイズ変更終了 |

##### 主なプロパティ

| プロパティ | 設定例 |
|-----------|-----------|
| Height | 変更対象 |
| Width | 変更対象 |
| MinimumSize | 最小サイズ |
| Cursor | SizeNS / SizeWE |

##### 主なカーソル

```csharp
Cursors.SizeNS
Cursors.SizeWE
Cursors.SizeNWSE
```
---

#### 3.7 右クリックメニュー（ContextMenuStrip）

配置したユーザーコントロールを右クリックしたときに、削除などのメニューを表示する。

##### 設定のポイント

- `ContextMenuStrip` を追加するのは、メニューを管理する `frmMain` 側。
- `UserControl` を継承したクラスには、`ContextMenuStrip` プロパティが最初から用意されている。`ucrTodoSimple` 側で独自に追加する必要はない。
- 削除対象のコントロールを `new` した後、フォーム側で作成した `ContextMenuStrip` を割り当てる。

##### 設定例

```csharp
// frmMainで削除対象のコントロールを作成した後
ucrTodoSimple todoSimple = new ucrTodoSimple();

// frmMain側のContextMenuStripを紐づける
todoSimple.ContextMenuStrip = this.contextMenuStrip1;
```

##### 動作確認時の注意点

右クリックメニューを表示しただけでは、削除対象のコントロールが選択状態になっていない場合がある。削除処理が選択状態を前提としているなら、右クリックしたコントロールを削除対象として扱えるようにする必要がある。
