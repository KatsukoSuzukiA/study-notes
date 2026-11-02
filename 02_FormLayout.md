## C# WinForms 学習内容 索引

### 2. 画面レイアウトのテクニック

#### 2.1 Panel系コントロールの使い分け

WinFormsではコントロールを適切に配置するために、Panel系コントロールを組み合わせて画面を構成する。

#### 2.1 Panel系コントロールの使い分け

##### Panel

コントロールをまとめるための最も基本的なコンテナ。

- 自由なレイアウトを行いたい場合に使用する
- 他のコンテナより制約が少ない
- スクロール可能な領域を作れる

主なプロパティ

| プロパティ | 設定例 | 説明 |
|-----------|---------|------|
| Dock | Fill | 親コンテナ全体に広げる |
| AutoScroll | false | スクロールバーを表示しない |
| BorderStyle | FixedSingle | 枠線を表示 |
| BackColor | LightGray | 背景色 |

利用例

- メイン表示領域
- ユーザーコントロールの配置先
- スクロール可能な一覧画面

---

##### TableLayoutPanel

行と列の表形式でコントロールを配置するコンテナ。

- 画面サイズ変更時もレイアウトが崩れにくい
- 入力フォームとの相性が良い
- RowSpan、ColumnSpanによるセル結合が可能

主なプロパティ

| プロパティ | 設定例 | 説明 |
|-----------|---------|------|
| Dock | Fill | 親領域全体へ配置 |
| ColumnCount | 2 | 列数 |
| RowCount | 5 | 行数 |
| AutoSize | true | 内容に合わせてサイズ変更 |
| CellBorderStyle | Single | セル境界線表示 |

主な設定

##### 列幅・行高

```text
SizeType.Percent
```

例

```text
30%
70%
```

- 画面サイズ変更に追従する
- 最も利用頻度が高い

```text
SizeType.Absolute
```

例

```text
100px
200px
```

- 固定サイズ

```text
SizeType.AutoSize
```

- 内容に応じて調整

##### セル結合

```csharp
tableLayoutPanel1.SetColumnSpan(txtName, 2);
```

- 2列分使用

```csharp
tableLayoutPanel1.SetRowSpan(txtMemo, 3);
```

- 3行分使用

利用例

- 患者情報入力画面
- 設定画面
- 検索条件エリア

---

##### FlowLayoutPanel

コントロールを順番に並べるコンテナ。

- 動的なコントロール追加との相性が良い
- ボタン一覧やTodo一覧に向いている
- 自動折り返しが可能

主なプロパティ

| プロパティ | 設定例 | 説明 |
|-----------|---------|------|
| Dock | Fill | 親全体に配置 |
| AutoScroll | true | スクロールバー表示 |
| WrapContents | true | 自動折り返し |
| FlowDirection | TopDown | 配置方向 |

##### 配置方向

```csharp
flowLayoutPanel1.FlowDirection =
    FlowDirection.LeftToRight;
```

左から右へ配置

```csharp
flowLayoutPanel1.FlowDirection =
    FlowDirection.TopDown;
```

上から下へ配置

指定可能な値

```text
LeftToRight
RightToLeft
TopDown
BottomUp
```

利用例

- Todo一覧
- ボタンメニュー
- タグ一覧
- 動的に追加されるユーザーコントロール

---

##### SplitContainer

画面を2つの領域に分割するコンテナ。

- ユーザーが境界線をドラッグできる
- 一覧と詳細の画面構成でよく利用する

主なプロパティ

| プロパティ | 設定例 | 説明 |
|-----------|---------|------|
| Dock | Fill | 親全体へ配置 |
| Orientation | Vertical | 左右分割 |
| Orientation | Horizontal | 上下分割 |
| SplitterDistance | 300 | 分割位置 |
| FixedPanel | Panel1 | 左側固定 |
| Panel1MinSize | 200 | 最小サイズ |
| Panel2MinSize | 200 | 最小サイズ |

利用例

- 左側：患者一覧
- 右側：患者詳細

または

- 上側：検索条件
- 下側：検索結果
参照：frmMain

---

#### 2.2 WinFormsで覚えておきたいプロパティ

レイアウト調整で頻繁に使用する代表的なプロパティ。

- **Dock**
  - 親コンテナの端や全体にコントロールを固定する
  - Fill を指定すると残り領域全体に広がる

- **Anchor**
  - 親コントロールとの距離を維持する
  - フォームサイズ変更時に位置やサイズを調整できる

- **AutoSize**
  - 内容に合わせてサイズを自動調整する

- **AutoSizeMode**
  - AutoSize の動作方法を指定する

- **Orientation**
  - 横方向・縦方向の切り替えに使用する
  - SplitContainer などで利用される

- **ColumnCount**
  - TableLayoutPanel の列数を指定する

---

#### 2.3 TableLayoutPanelの基本操作

TableLayoutPanelは行と列を使ってコントロールを管理する。

- **Percent**
  - パーセント指定で領域を分割する
  - 画面サイズ変更に強い

- **Absolute**
  - 固定ピクセル数でサイズを指定する

- **ColumnSpan**
  - 複数列にまたがって配置する

- **RowSpan**
  - 複数行にまたがって配置する

- 行・列の追加方法
- RowStyles と ColumnStyles の設定方法
- 画面サイズ変更時のレイアウト調整

---

#### 2.4 SplitContainerの基本操作

1つの画面を複数領域に分けて表示する方法を学ぶ。

- 分割方向（縦・横）の設定
- SplitterDistance による分割位置調整
- Panel1・Panel2へのコントロール配置
- 最小サイズ制限の設定
- 固定パネルの設定
- サイズ変更時の動作確認

---

#### 2.5 入力系コントロール

ユーザーから情報を入力してもらうためのコントロールの活用方法。

##### トグルボタンの作成

- RadioButton を使った排他的選択
- CheckBox を使った ON/OFF 切り替え
- 色変更による選択状態の表現

##### パネルやラベルのリスト管理

- コントロールを List に格納する
- Tag プロパティを利用する
- LINQで必要なコントロールだけ取得する
- 一括処理を行う

##### データ追加可能なコンボボックス

- ComboBox の基本設定
- 候補一覧の管理
- 一覧にない文字列の入力
- AutoComplete の利用

##### チェックリストボックス

- CheckedListBox の作成
- CheckOnClick の設定
- チェック済み項目の取得
- 未チェック項目の取得
- 一括チェック・解除